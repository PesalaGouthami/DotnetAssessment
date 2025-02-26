using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MoviesViewModelAss.Models;

namespace MoviesViewModelAss.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login(string ReturnUrl)
        {
            ViewData.Add("ReturnUrl", ReturnUrl);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult>  Login(UserDetails user,string ReturnUrl)
        {
            if (user.UserName == "admin" && user.Password == "admin123" && user.Role == "admin")
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(ClaimTypes.Role, user.Role="admin")
                };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return Redirect(ReturnUrl);
            }

            else if (user.UserName == "guest" && user.Password == "guest123" && user.Role=="")
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, user.UserName)
                };
                var claimsIdentity= new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity));
                return Redirect(ReturnUrl);
            }
            else
            {
                ViewData.Add("ReturnUrl", ReturnUrl);
                ViewData.Add("msg", "invalid username/password");
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Home/Index");
        }
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
