using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_chanse99.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_chanse99.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieCollectionContext blahContext { get; set; }

        //Constructor
        public HomeController(ILogger<HomeController> logger, MovieCollectionContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewMovie()
        {
            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult AddNewMovie(MovieResponse mr)
        {
            if (ModelState.IsValid) // if the model is valid, display the confirmation page
            {
                blahContext.Add(mr);
                blahContext.SaveChanges();
                return View("Confirmation", mr);
            }
            else // if the model is invalid, display form page still
            {
                return View("MovieForm");
            }
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
