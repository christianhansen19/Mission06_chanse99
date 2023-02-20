using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private MovieCollectionContext mcContext { get; set; }

        //Constructor
        public HomeController(MovieCollectionContext someName)
        {
            mcContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddNewMovie()
        {
            ViewBag.Categories = mcContext.Categories.ToList();
            return View("MovieForm");
        }

        [HttpPost]
        public IActionResult AddNewMovie(MovieResponse mr)
        {
            if (ModelState.IsValid) // if the model is valid, display the confirmation page
            {
                mcContext.Add(mr);
                mcContext.SaveChanges();
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

        public IActionResult MovieCollectionList()
        {
            var applications = mcContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.MovieTitle)
                .ToList();
            return View(applications);
        }
    }
}
