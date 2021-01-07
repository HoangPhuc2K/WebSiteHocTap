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
    public class LessonController : Controller
    {
        private readonly DPContext _context;

        public LessonController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Lesson
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Lesson.Include(l => l.Coach).Include(l => l.Course);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Lesson/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lessonModel = await _context.Lesson
                .Include(l => l.Coach)
                .Include(l => l.Course)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lessonModel == null)
            {
                return NotFound();
            }

            return View(lessonModel);
        }

        // GET: Admin/Lesson/Create
        public IActionResult Create()
        {
            ViewData["IdCoach"] = new SelectList(_context.Coach, "Id", "Address");
            ViewData["IdCourse"] = new SelectList(_context.Course, "Id", "Description");
            return View();
        }

        // POST: Admin/Lesson/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LessonName,IdCourse,IdCoach,Title,Video,Content,Description")] LessonModel lessonModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lessonModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCoach"] = new SelectList(_context.Coach, "Id", "Address", lessonModel.IdCoach);
            ViewData["IdCourse"] = new SelectList(_context.Course, "Id", "Description", lessonModel.IdCourse);
            return View(lessonModel);
        }

        // GET: Admin/Lesson/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lessonModel = await _context.Lesson.FindAsync(id);
            if (lessonModel == null)
            {
                return NotFound();
            }
            ViewData["IdCoach"] = new SelectList(_context.Coach, "Id", "Address", lessonModel.IdCoach);
            ViewData["IdCourse"] = new SelectList(_context.Course, "Id", "Description", lessonModel.IdCourse);
            return View(lessonModel);
        }

        // POST: Admin/Lesson/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LessonName,IdCourse,IdCoach,Title,Video,Content,Description")] LessonModel lessonModel)
        {
            if (id != lessonModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lessonModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LessonModelExists(lessonModel.Id))
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
            ViewData["IdCoach"] = new SelectList(_context.Coach, "Id", "Address", lessonModel.IdCoach);
            ViewData["IdCourse"] = new SelectList(_context.Course, "Id", "Description", lessonModel.IdCourse);
            return View(lessonModel);
        }

        // GET: Admin/Lesson/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lessonModel = await _context.Lesson
                .Include(l => l.Coach)
                .Include(l => l.Course)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lessonModel == null)
            {
                return NotFound();
            }

            return View(lessonModel);
        }

        // POST: Admin/Lesson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lessonModel = await _context.Lesson.FindAsync(id);
            _context.Lesson.Remove(lessonModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LessonModelExists(int id)
        {
            return _context.Lesson.Any(e => e.Id == id);
        }
    }
}
