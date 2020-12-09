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
        public IActionResult Create()
        {
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName");
            return View();
        }

        // POST: Admin/AdminForum/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Email,Address,Phone,IdUser")] AdminForumModel adminForumModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adminForumModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", adminForumModel.IdUser);
            return View(adminForumModel);
        }

        // GET: Admin/AdminForum/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminForumModel = await _context.AdminForum.FindAsync(id);
            if (adminForumModel == null)
            {
                return NotFound();
            }
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", adminForumModel.IdUser);
            return View(adminForumModel);
        }

        // POST: Admin/AdminForum/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Email,Address,Phone,IdUser")] AdminForumModel adminForumModel)
        {
            if (id != adminForumModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminForumModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminForumModelExists(adminForumModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", adminForumModel.IdUser);
            return View(adminForumModel);
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
