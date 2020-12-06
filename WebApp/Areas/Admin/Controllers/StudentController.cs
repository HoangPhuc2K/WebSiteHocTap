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
    [Area("Admin_WebSite")]
    public class StudentController : Controller
    {
        private readonly DPContext _context;

        public StudentController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin_WebSite/Student
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Student.Include(s => s.User);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin_WebSite/Student/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.Student
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentModel == null)
            {
                return NotFound();
            }

            return View(studentModel);
        }

        // GET: Admin_WebSite/Student/Create
        public IActionResult Create()
        {
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName");
            return View();
        }

        // POST: Admin_WebSite/Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Email,Address,Phone,IdUser")] StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", studentModel.IdUser);
            return View(studentModel);
        }

        // GET: Admin_WebSite/Student/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.Student.FindAsync(id);
            if (studentModel == null)
            {
                return NotFound();
            }
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", studentModel.IdUser);
            return View(studentModel);
        }

        // POST: Admin_WebSite/Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Email,Address,Phone,IdUser")] StudentModel studentModel)
        {
            if (id != studentModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentModelExists(studentModel.Id))
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
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "AccountName", studentModel.IdUser);
            return View(studentModel);
        }

        // GET: Admin_WebSite/Student/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.Student
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentModel == null)
            {
                return NotFound();
            }

            return View(studentModel);
        }

        // POST: Admin_WebSite/Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentModel = await _context.Student.FindAsync(id);
            _context.Student.Remove(studentModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentModelExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}
