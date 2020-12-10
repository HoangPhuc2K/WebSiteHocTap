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

namespace WebApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class AdminController : Controller
    {
        private readonly DPContext _context;

        public AdminController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Admin
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Admin.Include(a => a.User);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Admin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminModel = await _context.Admin
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminModel == null)
            {
                return NotFound();
            }

            return View(adminModel);
        }

        // GET: Admin/Admin/Create
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName");
                return View(new AdminModel());
            }
            else
            {
                var adminModel = await _context.Admin.FindAsync(id);
                if (adminModel == null)
                {
                    return NotFound();
                }
                ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", adminModel.Id);
                return View(adminModel);
            }
        }

        // POST: Admin/Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id,[Bind("Id,FullName,Email,Address,Phone,IdUser")] AdminModel adminModel)
        {
            if (ModelState.IsValid)
            {
                if (id == 0)
                {
                    _context.Add(adminModel);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(adminModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!AdminModelExists(adminModel.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", adminModel.IdUser);
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.Admin.ToList()) });
            }
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", adminModel.IdUser);
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", adminModel)});
        }


        // GET: Admin/Admin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminModel = await _context.Admin
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminModel == null)
            {
                return NotFound();
            }

            return View(adminModel);
        }

        // POST: Admin/Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adminModel = await _context.Admin.FindAsync(id);
            _context.Admin.Remove(adminModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminModelExists(int id)
        {
            return _context.Admin.Any(e => e.Id == id);
        }
    }
}
