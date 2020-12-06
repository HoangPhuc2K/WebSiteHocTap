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
    public class PostController : Controller
    {
        private readonly DPContext _context;

        public PostController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin_WebSite/Post
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Post.Include(p => p.Student);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin_WebSite/Post/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postModel = await _context.Post
                .Include(p => p.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postModel == null)
            {
                return NotFound();
            }

            return View(postModel);
        }

        // GET: Admin_WebSite/Post/Create
        public IActionResult Create()
        {
            ViewData["IdStudent"] = new SelectList(_context.Student, "Id", "Phone");
            return View();
        }

        // POST: Admin_WebSite/Post/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Descripsion,Content,IdStudent")] PostModel postModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(postModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdStudent"] = new SelectList(_context.Student, "Id", "Phone", postModel.IdStudent);
            return View(postModel);
        }

        // GET: Admin_WebSite/Post/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postModel = await _context.Post.FindAsync(id);
            if (postModel == null)
            {
                return NotFound();
            }
            ViewData["IdStudent"] = new SelectList(_context.Student, "Id", "Phone", postModel.IdStudent);
            return View(postModel);
        }

        // POST: Admin_WebSite/Post/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Descripsion,Content,IdStudent")] PostModel postModel)
        {
            if (id != postModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(postModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PostModelExists(postModel.Id))
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
            ViewData["IdStudent"] = new SelectList(_context.Student, "Id", "Phone", postModel.IdStudent);
            return View(postModel);
        }

        // GET: Admin_WebSite/Post/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var postModel = await _context.Post
                .Include(p => p.Student)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (postModel == null)
            {
                return NotFound();
            }

            return View(postModel);
        }

        // POST: Admin_WebSite/Post/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var postModel = await _context.Post.FindAsync(id);
            _context.Post.Remove(postModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PostModelExists(int id)
        {
            return _context.Post.Any(e => e.Id == id);
        }
    }
}
