using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopApp.business.Abstract;
using ShopApp.webui.EmailServices;
using ShopApp.webui.Extensions;
using ShopApp.webui.Identity;
using ShopApp.webui.Models;

namespace ShopApp.webui.Controllers
{
    // [ValidateAntiForgeryToken]
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _mailSender;
        private ICartService _cartService;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender mailSender, ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mailSender = mailSender;
            _cartService = cartService;
        }

        [AllowAnonymous]
        public IActionResult Login(string ReturnUrl = null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Username is not found");
                return View(model);
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Please confirm your account");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }
            //3. parametre tarayıcı kapanınca bilginin tutulup tutulmayacağını gösteir
            ModelState.AddModelError("", "Username or password is wrong");
            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                //generate token
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var url = Url.Action("ConfirmMail", "Account", new { UserId = user.Id, token = token });
                Console.WriteLine(url);
                await _mailSender.SendEmailAsync(model.Email, "Confirmasyon Mail", $"Please <a href='http://localhost:5000{url}'>click</a> for confirm your account");

                return RedirectToAction("Login", "Account");
            }
            ModelState.AddModelError("Password", "Please try again");
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData.Put("message", new AlertMessage() { Title = "Session is closed", Message = "Session is closed", AlertType = "success" });
            return Redirect("~/");
        }
        [AllowAnonymous]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgetPassword(string Email)
        {
            if (string.IsNullOrEmpty(Email))
            {
                return View();
            }
            var user = await _userManager.FindByEmailAsync(Email);
            if (user != null)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var url = Url.Action("ResetPassword", "Account", new { UserId = user.Id, token = token });
                Console.WriteLine(url);
                await _mailSender.SendEmailAsync(Email, "Reset Password", $"Please <a href='http://localhost:5000{url}'>click</a> for reset your password");

                return Redirect("ResetPassword");
            }
            return View();
        }
        [AllowAnonymous]
        public IActionResult ResetPassword(string userId, string Token)
        {
            if (userId == null || Token == null)
            {
                return RedirectToAction("Index", "Home ");
            }
            var model = new ResetPasswordModel { Token = Token };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "User is not found");
                return View(model);
            }
            var result = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
            if (result.Succeeded)
            {
                return RedirectToAction("Login", "Account");
            }
            ModelState.AddModelError("", "An undefined Error");
            return View(model);

        }
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmMail(string UserId, string Token)
        {
            if (UserId == null || Token == null)
            {
                TempData.Put("message", new AlertMessage() { Title = "Invalid Token", Message = "Invalid Token", AlertType = "danger" });
                return View();
            }
            var user = await _userManager.FindByIdAsync(UserId);
            if (user == null)
            {
                TempData.Put("message", new AlertMessage() { Title = "User Info", Message = "User is not found", AlertType = "danger" });
                return View();
            }
            var result = await _userManager.ConfirmEmailAsync(user, Token);
            if (result.Succeeded)
            {
                //cart obkjesini oluştur.
                _cartService.InıtializeCard(user.Id);
                TempData.Put("message", new AlertMessage() { Title = "Account", Message = "Account is confirmed", AlertType = "success" });
                return View();
            }
            return View();
        }
        public IActionResult accessdenied()
        {


            return View();
        }

    }
}