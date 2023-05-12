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
    public class CinemaController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        // GET: Cinema
        public async Task<ActionResult> Index(int?i)
        {
            Session["ControlName"] = "Cinema";
            var Cinemas = await context.Cinemas.ToListAsync();
            return View(Cinemas.ToPagedList(i ?? 1, 3));
        }
        public async Task<ActionResult> Search(string search, int? i)
        {
            search = search.Trim();
            ViewBag.SearchTerm = search;
            var cinemas = await context.Cinemas.Where(x => SqlFunctions.PatIndex("%" + search + "%", x.Name) > 0 || search == null).ToListAsync();
            return View("index", cinemas.ToPagedList(i ?? 1, 3));
        }
    }
}