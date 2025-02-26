using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesViewModelAss.Models;

namespace MoviesViewModelAss.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly IMoviesDataAccess dal;
        public HomeController(IMoviesDataAccess dal)
        {
            this.dal = dal;
        }
        [Authorize]
        public IActionResult Index()
        {
            MoviesVM vm = new MoviesVM();

            vm.movies = dal.GetMovies();
            return View(vm);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(Movies movies)
        {
            dal.AddMovie(movies);
            return RedirectToAction("Index");
        }
        
    }
}
