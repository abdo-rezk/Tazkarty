using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Tazkarty.Models;

namespace Tazkarty.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        // GET: Movies
        public async Task<ActionResult> Index(int?i)
        {
            Session["ControlName"] = "Movies";
            var Movies = await context.Movies.ToListAsync();
            return View(Movies.ToPagedList(i ?? 1, 3)); // number of page , number of item
        }
        public async Task<ActionResult> Search(string search, int? i)
        {
            search = search.Trim();
            ViewBag.SearchTerm = search;
            var movies = await context.Movies.Where(x => SqlFunctions.PatIndex("%" + search + "%", x.Name) > 0 || search == null).ToListAsync();
            return View("index", movies.ToPagedList(i ?? 1, 3));
        }
    }
}