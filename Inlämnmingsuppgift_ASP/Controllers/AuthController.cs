using Inlämnmingsuppgift_ASP.Models;
using Inlämnmingsuppgift_ASP.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Inlämnmingsuppgift_ASP.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AuthController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        #region SignUp
        [HttpGet]
        public IActionResult SignUp()
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToAction("index", "home");

            return View();
        }

        //[HttpPost]
        public async Task<IActionResult> SignUp(SignUpModels model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    UserName = model.Email,
                    Email = model.Email,

                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    StreetName = model.StreetName,
                    PostalCode = model.PostalCode,
                    City = model.City,
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);


            }

            return View();
        }
        #endregion

        #region SignIn
        public IActionResult SignIn(string returnUrl = null)
        {
            var signInViewModel = new SignInModels();
            if (returnUrl == null)
                signInViewModel.ReturnUrl = "/";
            else
                signInViewModel.ReturnUrl = returnUrl;

            return View(signInViewModel);

        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModels model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: false, false);
                if (result.Succeeded)
                {
                    if (model.ReturnUrl == null || model.ReturnUrl == "/")
                        return RedirectToAction("Index", "Home");
                    else
                        return LocalRedirect(model.ReturnUrl);
                }
            }

            ModelState.AddModelError(string.Empty, "Wrong Email or Password");

            return View();
        }
        #endregion

        #region SignOut
        public async Task<IActionResult> SignOut()
        {
            if (_signInManager.IsSignedIn(User))
                await _signInManager.SignOutAsync();
            return RedirectToAction("index", "home");
        }
        #endregion
    }
}
