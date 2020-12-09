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
    public class CommemtPostController : Controller
    {
        private readonly DPContext _context;

        public CommemtPostController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/CommemtPost
        public async Task<IActionResult> Index()
        {
            return View(await _context.CommemtPost.ToListAsync());
        }

        // GET: Admin/CommemtPost/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commemtPostModel = await _context.CommemtPost
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commemtPostModel == null)
            {
                return NotFound();
            }

            return View(commemtPostModel);
        }
        // Admin/Roles/AddOrEdit
        // GET: Transaction/AddOrEdit/5(Update)
        [NoDirectAccess]
        public async Task<IActionResult> AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new CommemtPostModel());
            else
            {
                var commemtPostModel = await _context.Roles.FindAsync(id);
                if (commemtPostModel == null)
                {
                    return NotFound();
                }
                return View(commemtPostModel);
            }
        }


        // POST: Admin/CommemtPost/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,IdPost")] CommemtPostModel commemtPostModel)
        {
            if (ModelState.IsValid)
            {
                //insert
                if (id == 0)
                {
                    _context.Add(commemtPostModel);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(commemtPostModel);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CommemtPostModelExists(commemtPostModel.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                return Json(new { isValid = true, html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.CommemtPost.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", commemtPostModel) });
        }

        // GET: Admin/CommemtPost/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commemtPostModel = await _context.CommemtPost
                .Include(c => c.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commemtPostModel == null)
            {
                return NotFound();
            }

            return View(commemtPostModel);
        }

        // POST: Admin/CommemtPost/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commemtPostModel = await _context.CommemtPost.FindAsync(id);
            _context.CommemtPost.Remove(commemtPostModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommemtPostModelExists(int id)
        {
            return _context.CommemtPost.Any(e => e.Id == id);
        }
    }
}
