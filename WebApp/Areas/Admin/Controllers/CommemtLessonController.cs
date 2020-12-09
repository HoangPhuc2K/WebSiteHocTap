using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Areas.Admin.Data;
using WebApp.Areas.Admin.Models;
using static WebApp.Helper;

namespace WebApp.Areas.Admin.Controllers
{
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
            return View(await _context.CommemtLesson.ToListAsync());
        }

        // GET: Admin/CommemtLesson/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commemtLessonModel = await _context.CommemtLesson
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commemtLessonModel == null)
            {
                return NotFound();
            }

            return View(commemtLessonModel);
        }

        // Admin/Roles/AddOrEdit
        // GET: Transaction/AddOrEdit/5(Update)
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new CommemtLessonModel());
            else
            {
                var commemtLessonModel = await _context.Roles.FindAsync(id);
                if (commemtLessonModel == null)
                {
                    return NotFound();
                }
                return View(commemtLessonModel);
            }
        }
        // POST: Admin/CommemtLesson/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,IdLesson")] CommemtLessonModel commemtLessonModel)
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

                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.CommemtLesson.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", commemtLessonModel) });
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
