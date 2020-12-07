using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Areas.Admin.Data;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoachController : Controller
    {
        private readonly DPContext _context;

        public CoachController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Coach
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Coach.Include(c => c.User);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Coach/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coachModel = await _context.Coach
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coachModel == null)
            {
                return NotFound();
            }

            return View(coachModel);
        }

        // GET: Admin/Coach/Create
        public IActionResult Create()
        {
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName");
            return View();
        }

        // POST: Admin/Coach/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountName,AccountPassword,Email,Address,Phone,IdUser")] CoachModel coachModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coachModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", coachModel.IdUser);
            return View(coachModel);
        }

        // GET: Admin/Coach/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coachModel = await _context.Coach.FindAsync(id);
            if (coachModel == null)
            {
                return NotFound();
            }
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", coachModel.IdUser);
            return View(coachModel);
        }

        // POST: Admin/Coach/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AccountName,AccountPassword,Email,Address,Phone,IdUser")] CoachModel coachModel)
        {
            if (id != coachModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coachModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoachModelExists(coachModel.Id))
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
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", coachModel.IdUser);
            return View(coachModel);
        }

        // GET: Admin/Coach/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coachModel = await _context.Coach
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (coachModel == null)
            {
                return NotFound();
            }

            return View(coachModel);
        }

        // POST: Admin/Coach/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var coachModel = await _context.Coach.FindAsync(id);
            _context.Coach.Remove(coachModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CoachModelExists(int id)
        {
            return _context.Coach.Any(e => e.Id == id);
        }
    }
}
