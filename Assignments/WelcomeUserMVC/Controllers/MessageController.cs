using Microsoft.AspNetCore.Mvc;

namespace WelcomeUserMVC.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DisplayName(string username)
        {
            ViewBag.username = username;
            return View();
        }
    }
}
