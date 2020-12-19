using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Areas.Admin.Data;
using WebApp.Areas.Admin.Models;
using static WebApp.Helper;

namespace WebApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AdminForumController : Controller
    {
        private readonly DPContext _context;

        public AdminForumController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminForum
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.AdminForum.Include(a => a.User);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/AdminForum/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminForumModel = await _context.AdminForum
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminForumModel == null)
            {
                return NotFound();
            }

            return View(adminForumModel);
        }

        // GET: Admin/AdminForum/Create
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName");
                return View(new AdminForumModel());
            }
            else
            {
                var adminForumModel = await _context.AdminForum.FindAsync(id);
                if (adminForumModel == null)
                {
                    return NotFound();
                }
                ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName",adminForumModel.Id);
                return View(adminForumModel);
            }
        }

        // POST: Admin/AdminForum/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id,[Bind("Id,FullName,Email,Address,Phone,IdUser")] AdminForumModel adminForumModel)
        {

            if (ModelState.IsValid)
            {
                // Insert
                if (id == 0)
                {
                    _context.Add(adminForumModel);
                    await _context.SaveChangesAsync();

                }
                //Update
                else
                {
                    try
                    {
                        _context.Update(adminForumModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!AdminForumModelExists(adminForumModel.Id))
                        { return NotFound(); }
                        else
                        { throw; }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.AdminForum.Include(sp => sp.User).ToList()) });
            }
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", adminForumModel.Id);
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", adminForumModel) });
        }

        // GET: Admin/AdminForum/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminForumModel = await _context.AdminForum
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminForumModel == null)
            {
                return NotFound();
            }

            return View(adminForumModel);
        }

        // POST: Admin/AdminForum/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adminForumModel = await _context.AdminForum.FindAsync(id);
            _context.AdminForum.Remove(adminForumModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminForumModelExists(int id)
        {
            return _context.AdminForum.Any(e => e.Id == id);
        }
    }
}
