using System;
using System.Linq;
using System.Threading.Tasks;
using MarketingApp.WebUI.EmailServices;
using MarketingApp.WebUI.Extensions;
using MarketingApp.WebUI.Models;
using MarketingApp.WebUI.Models.identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MarketingApp.WebUI.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        private IEmailSender _emailSender;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl=null)
        {
            return View(new LoginModel(){
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);

            if(user == null)
            {
                ModelState.AddModelError("","Bu Email ile daha önce hesap oluşturulmamış");
                return View(model);
            }
            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("","Lütfen Email hesabınıza gelen link ile hesabınızı onaylayınız.");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }
            ModelState.AddModelError("","Girilen kullanıcı adı veya parola yanlış");
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();    
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var applicationUser = new ApplicationUser()
            {
                Name = model.FirstName,
                LastName = model.LastName,
                UserName = model.UserName,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(applicationUser,model.Password);
            if (result.Succeeded)
            {
                //generate token
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(applicationUser);
                var url = Url.Action("ConfirmEmail","Account", new {
                    userId = applicationUser.Id,
                    token = code
                });
                //email confirmed
                await _emailSender.SendEmailAsync(model.Email,"MarketingApp Onay Mesajı.",
                $"Hesabınız başarılı bir şekilde oluşturuldu {@model.UserName} <hr/> Lütfen email hesabınızı onaylamak için  <a href='http://localhost:5000{url}'>linke</a> tıklayınız");
                
                TempData.Put("message", new AlertMessage{
                    Message="Hesabınız başarılı bir şekilde oluşturuldu. Lütfen Emailinize gelen linkten hesabınızı onaylayınız.",
                    AlertType="success" 
                });
                
                return RedirectToAction("Login","Account");
            }
            else{
                result.Errors.ToList().ForEach(e=> ModelState.AddModelError(e.Code,e.Description));
            }

            return View();    
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData.Put("message", new AlertMessage{
                    Message="Geçersiz Token",
                    AlertType="danger" 
                });
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user,token);
                if (result.Succeeded)
                {
                    TempData.Put("message", new AlertMessage{
                        Message="Hesabınız onaylandı.",
                        AlertType="success" 
                    });
                    return RedirectToAction("Login","Account");
                }
            }

            TempData.Put("message", new AlertMessage{
                Message="Hesabınız onaylanmadı",
                AlertType="danger" 
            });
            return RedirectToAction("Login","Account");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var url = Url.Action("ResetPassword","Account",new{
                    userId = user.Id,
                    token = code
                });

                await _emailSender.SendEmailAsync(email,"MarketingApp Parola Sıfırlama İsteği.",
                $"Lütfen parolanızı sıfırlamak için <a href='http://localhost:5000{url}'>linke</a> tıklayınız");

                TempData.Put("message", new AlertMessage{
                    Message="Şifrenizi sıfırlamak için Emailinize gelen linki kontrol ediniz.",
                    AlertType="warning" 
                });
                
                return RedirectToAction("Login","Account");
            }

            TempData.Put("message", new AlertMessage{
                Message="Bu Emaile kayıtlı kullanıcı bulunamadı..",
                AlertType="danger" 
            });
            
            return RedirectToAction("Login","Account");
        }

        [HttpGet]
        public IActionResult ResetPassword(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return View();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                var result = await _userManager.ResetPasswordAsync(user,model.Token,model.Password);
                if(result.Succeeded)
                {
                    TempData.Put("message", new AlertMessage{
                        Message="Şifreniz yenilendi.",
                        AlertType="success" 
                    });
                    
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    result.Errors.ToList().ForEach(a=> ModelState.AddModelError(a.Code,a.Description));
                    return View(model);
                }    
            }
            return View(model);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}