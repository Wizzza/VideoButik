using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoButik2.Models;

namespace VideoButik2.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Movies()
        {

            List<MovieModel> Movies = new List<MovieModel>();

            Movies.Add(new MovieModel { Name = "Terminator", Genre = "action", Length = 120 });

            return View(Movies);
        }
    }
}