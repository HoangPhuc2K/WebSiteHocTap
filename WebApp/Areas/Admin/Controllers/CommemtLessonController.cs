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
    public class CommemtLessonController : Controller
    {
        private readonly DPContext _context;

        public CommemtLessonController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/CommemtLesson
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.CommemtLesson.Include(c => c.Lesson);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/CommemtLesson/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commemtLessonModel = await _context.CommemtLesson
                .Include(c => c.Lesson)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commemtLessonModel == null)
            {
                return NotFound();
            }

            return View(commemtLessonModel);
        }

        // GET: Admin/CommemtLesson/Create
        public IActionResult Create()
        {
            ViewData["IdLesson"] = new SelectList(_context.Lesson, "Id", "Content");
            return View();
        }

        // POST: Admin/CommemtLesson/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,IdLesson")] CommemtLessonModel commemtLessonModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(commemtLessonModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdLesson"] = new SelectList(_context.Lesson, "Id", "Content", commemtLessonModel.IdLesson);
            return View(commemtLessonModel);
        }

        // GET: Admin/CommemtLesson/Edit/5
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                ViewData["IdLesson"] = new SelectList(_context.Lesson, "Id", "Content");
                return View(new CommemtLessonModel());
            }
            else
            {
                var commemtLessonModel = await _context.CommemtLesson.FindAsync(id);
                if (commemtLessonModel == null)
                {
                    return NotFound();
                }
                ViewData["IdLesson"] = new SelectList(_context.Lesson, "Id", "Content", commemtLessonModel.Id);
                return View(commemtLessonModel);
            }

            
        }

        // POST: Admin/CommemtLesson/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("Id,Title,Content,IdLesson")] CommemtLessonModel commemtLessonModel)
        {

            if (ModelState.IsValid)
            {
                if(id == 0)
                {
                    _context.Add(commemtLessonModel);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(commemtLessonModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CommemtLessonModelExists(commemtLessonModel.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                ViewData["IdLesson"] = new SelectList(_context.Lesson, "Id", "Content", commemtLessonModel.IdLesson);
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.CommemtLesson.ToList()) });
            }
            ViewData["IdLesson"] = new SelectList(_context.Lesson, "Id", "Content", commemtLessonModel.IdLesson);
            return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll",commemtLessonModel) });
        }

        // GET: Admin/CommemtLesson/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commemtLessonModel = await _context.CommemtLesson
                .Include(c => c.Lesson)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commemtLessonModel == null)
            {
                return NotFound();
            }

            return View(commemtLessonModel);
        }

        // POST: Admin/CommemtLesson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commemtLessonModel = await _context.CommemtLesson.FindAsync(id);
            _context.CommemtLesson.Remove(commemtLessonModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommemtLessonModelExists(int id)
        {
            return _context.CommemtLesson.Any(e => e.Id == id);
        }
    }
}
