using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//2
using VideoApp.Models;

namespace VideoApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            // 1
            var movie = new Movie() { Name = "Psycho" };

            return View(movie);
        }
    }
}