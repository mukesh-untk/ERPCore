using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERPCore.AppDb;
using ERPCore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MVCPattern.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public RoleManager<IdentityRole> RoleManager { get; }

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            RoleManager = roleManager;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            return View(user);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Profile(IdentityUser user)
        {
            if (ModelState.IsValid)
            {
                var c = await _userManager.UpdateAsync(user);
                foreach (var item in c.Errors)
                {
                    ModelState.AddModelError(item.Code, item.Description);
                }
            }
            return View(user);
        }

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                if (Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Login Failed");
            }

            return View(model);
        }

        public async Task<ActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = model.Email, Email = model.Email };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    string role = "user";
                    await _userManager.AddToRoleAsync(user, role);

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            // If we got this far, something failed, re-display form
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult NotAuthorized()
        {
            TempData["error"] = "You are not Authorized for this Action.";
            return RedirectToAction("Index", "Employee");
        }
    }
}