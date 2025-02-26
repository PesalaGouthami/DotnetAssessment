using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Newtonsoft.Json;
using RentCalculationMVC.Models;

namespace RentCalculationMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculate(User user)
        {
            //ViewBag.name = name;
            //ViewBag.owner = owner;
            //ViewBag.cost=cost;
            //ViewBag.start=start.ToString();
            //ViewBag.end=end.ToString();
            //TimeSpan timeSpan = end - start;
            //int date = timeSpan.Days;
            //ViewBag.totalcost = cost *date;

            if (ModelState.IsValid)
            {
                TimeSpan time = user.EndDate - user.StartDate;
                int date = time.Days;
                user.rent = user.Cost * date;
                return View("Calculate",user);
            }
            else
            {
                return View("Index");
            }

        }
    }
}
