using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TP1.Models;

namespace TP1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<Film> MaListeFilm;

        public HomeController(ILogger<HomeController> logger)
        {

            MaListeFilm = FilmsController.Films.OrderByDescending(f => f.DateSortie.Year).Take(3).ToList();
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(MaListeFilm);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
