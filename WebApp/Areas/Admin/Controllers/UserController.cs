using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Areas.Admin.Data;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly DPContext _context;

        public UserController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/User
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.User.Include(u => u.Roles);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.User
                .Include(u => u.Roles)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userModel == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // GET: Admin/User/Create
        public IActionResult Create()
        {
            ViewData["IdRoles"] = new SelectList(_context.Roles, "Id", "Name");
            return View();
        }

        // POST: Admin/User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountName,AccountPassword,IdRoles")] UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdRoles"] = new SelectList(_context.Roles, "Id", "Name", userModel.IdRoles);
            return View(userModel);
        }

        // GET: Admin/User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.User.FindAsync(id);
            if (userModel == null)
            {
                return NotFound();
            }
            ViewData["IdRoles"] = new SelectList(_context.Roles, "Id", "Name", userModel.IdRoles);
            return View(userModel);
        }

        // POST: Admin/User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AccountName,AccountPassword,ConfirmPassword,IdRoles")] UserModel userModel)
        {
            if (id != userModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserModelExists(userModel.Id))
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
            ViewData["IdRoles"] = new SelectList(_context.Roles, "Id", "Name", userModel.IdRoles);
            return View(userModel);
        }

        // GET: Admin/User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = await _context.User
                .Include(u => u.Roles)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userModel == null)
            {
                return NotFound();
            }

            return View(userModel);
        }

        // POST: Admin/User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userModel = await _context.User.FindAsync(id);
            _context.User.Remove(userModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserModelExists(int id)
        {
            return _context.User.Any(e => e.Id == id);
        }
        public IActionResult Login(string requestPath)
        {
            ViewBag.RequestPath = requestPath ?? "/";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            var result = _context.User.Where(sp => sp.AccountName == model.UserName && sp.AccountPassword == model.Password).FirstOrDefault();
            if(result == null)
            {
                return View();
            }
            // create claims
            string roles = null;
            if(result.IdRoles == 1)
            {
                roles = "Admin";
            }    
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, result.AccountName),
                new Claim(ClaimTypes.Role, roles),
            };

            // create identity
            ClaimsIdentity identity = new ClaimsIdentity(claims, model.UserName);

            // create principal
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            // sign-in
            await HttpContext.SignInAsync(
                    scheme: "SecurityScheme",
                    principal: principal,
                    properties: new AuthenticationProperties
                    {
                        IsPersistent =  true, // for 'remember me' feature
                        ExpiresUtc = DateTime.UtcNow.AddMinutes(60)
                    });

            return Redirect(model.RequestPath ?? "/");
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserModel user = new UserModel();
                user.AccountName = model.UserName;
                user.AccountPassword = model.Password;
                user.IdRoles = 1;
                _context.Add(user);
                await _context.SaveChangesAsync();
                var result = _context.User.Where(sp => sp.AccountName == model.UserName && sp.AccountPassword == model.Password).FirstOrDefault();
                if (result == null)
                {
                    return View();
                }
                // create claims
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, result.AccountName),
                    new Claim(ClaimTypes.Role, result.IdRoles.ToString()),
                };

                // create identity
                ClaimsIdentity identity = new ClaimsIdentity(claims, model.UserName);

                // create principal
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                // sign-in
                await HttpContext.SignInAsync(
                        scheme: "SecurityScheme",
                        principal: principal,
                        properties: new AuthenticationProperties
                        {
                            IsPersistent = true, // for 'remember me' feature
                        ExpiresUtc = DateTime.UtcNow.AddMinutes(60)
                        });
                return RedirectToRoute("Home");
            }
            return View();
        }
        public async Task<IActionResult> Logout(string requestPath)
        {
            await HttpContext.SignOutAsync(
                    scheme: "SecurityScheme");

            return RedirectToAction("Login");
        }

        public IActionResult Access()
        {
            return View();
        }
    }
}
