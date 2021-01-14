using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ODDB.BusinessLogic.Interfaces;
using ODDB.Common.Entities;
using ODDB.Models;
using System;

namespace ODDB.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("login")]
        public async Task<ActionResult> Login(LoginViewModel model, string Email, string wachtwoord)
        {
            if (!ModelState.IsValid) return View(model);

            var gebruiker = _accountRepository.GetUserByEmail(Email);
            if (gebruiker.Email == null)
            {
                ModelState.AddModelError("", "Het email-adres of het wachtwoord is incorrect");
                return View("Login");
            }
            else
            {
                var hasher = new PasswordHasher<User>();
                if (hasher.VerifyHashedPassword(gebruiker, gebruiker.Wachtwoord, wachtwoord) == PasswordVerificationResult.Failed)
                {
                    ModelState.AddModelError("", "Het email-adres of het wachtwoord is incorrect");
                    return View("Login");
                }
            }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, gebruiker.Naam),
                new Claim(ClaimTypes.NameIdentifier, gebruiker.UserID.ToString())
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties();

           await HttpContext.SignInAsync(
               CookieAuthenticationDefaults.AuthenticationScheme,
               new ClaimsPrincipal(claimsIdentity),
               authProperties);
            return LocalRedirect("/Account");
        }
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Login");
        }
        public IActionResult RegisterUser(string Naam, string Wachtwoord, string WachtwoordCheck, string Email)
        {
            if (Wachtwoord == WachtwoordCheck)
            {
                if (_accountRepository.GetUserByEmail(Email) == null)
                {
                    Guid ID = Guid.NewGuid();
                    var hasher = new PasswordHasher<User>();

                    string hashedPassword = hasher.HashPassword(new User(), Wachtwoord);

                    _accountRepository.RegisterUser(ID, Naam, Email, hashedPassword);

                    return RedirectToAction("Login");
                }
                else
                {
                    ModelState.AddModelError("", "Het email adres is al in gebruik");
                    return View("Register");
                }
            }
            else 
            {
                ModelState.AddModelError("", "De wachtwoorden komen niet overeen");
                return View("Register");
            }
        }
    }
}
