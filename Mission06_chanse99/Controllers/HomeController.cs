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
                ViewBag.Categories = mcContext.Categories.ToList();
                return View("MovieForm", mr);
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

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = mcContext.Categories.ToList();

            var movie = mcContext.responses.Single(x => x.MovieId == movieid);

            return View("MovieForm", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieResponse blah)
        {
            mcContext.Update(blah);
            mcContext.SaveChanges();
            return RedirectToAction("MovieCollectionList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = mcContext.responses.Single(x => x.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            mcContext.responses.Remove(mr);
            mcContext.SaveChanges();

            return RedirectToAction("MovieCollectionList");
        }
    }
}
