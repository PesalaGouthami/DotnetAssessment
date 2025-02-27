using HallBudgetMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HallBudgetMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly IHallDataAccess dal;
        public HomeController(IHallDataAccess dal)
        {
            this.dal = dal;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DisplayDetails(int budget)
        {
            var halls = dal.GetHalls(budget);
            return View(halls);
        }
    }
}
