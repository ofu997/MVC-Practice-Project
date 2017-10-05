using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using VideoApp.Models;

namespace VideoApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        // we can also write
        // public ViewResult Random()

        // what is passed to View when the url is /Random ?
        public ActionResult Random()
        {
            // 1
            var movie = new Movie() { Name = "Psycho" };

            return View(movie);

            // Action results: types and helper methods 
            // ViewResult, View(); PartialViewResult, PartialView(); ContentResult, Content();
            // RedirectResult, Redirect(); RedirectToRouteResult, RedirectToAction(); JsonResult, Json().

        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        // **custom route**
        public ActionResult ByReleaseDate(int? year, int month)
        {
            return Content(year+"/"+month);
        }
        
    }
}