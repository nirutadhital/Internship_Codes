using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyNotes.Models;
using MyNotes.ViewModels;

namespace MyNotes.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User>_signInManager;
        //dependency injection through constructor
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager=userManager;
            _signInManager=signInManager;

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }


        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                var user=new User()//RegisterViewModel bata ayeko data lai ya lagera save garxau
                {
                    FirstName=model.FirstName,
                    LastName=model.LastName,
                    Email=model.Email,
                    UserName=model.Email
               
                };
                var result= await _userManager.CreateAsync(user, model.Password);
                if(result.Succeeded)
                {
                    await _signInManager.PasswordSignInAsync(user, model.Password, false,false);
                    return RedirectToAction(nameof(Index), "home");
                }
            }
            return View(model);
            
        }


        [HttpGet("Login")]
        public IActionResult Login(string? returnUrl)
        {
            ViewBag.returnUrl=returnUrl;
            return View(new LoginViewModel());

        }
        
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl)
        {
            if(ModelState.IsValid)
            {
                var result=await _signInManager.PasswordSignInAsync(model.Username,model.Password,model.RememberMe,false);//false rakhyo vane laptop off garera on garda pheri login garnaparxa
                if(result.Succeeded)
                {
                    if(returnUrl==null)
                    {
                        return RedirectToAction(nameof(Index), "home");//home controller ko index action ma jana paryo
                    }
                    else
                    {
                        return LocalRedirect(returnUrl);
                    }
                }

            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Index), "Home");
        }

        
    }
}