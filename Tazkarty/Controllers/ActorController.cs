using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Tazkarty.Models;
using PagedList.Mvc;
using PagedList;
using System.Data.Entity.SqlServer;


namespace Tazkarty.Controllers
{
    public class ActorController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        // GET: Actor
        public async Task<ActionResult> Index(int?i)
        {
            Session["ControlName"] = "Actor";
            var Actors = await context.Actors.ToListAsync();
            return View(Actors.ToPagedList(i ?? 1,3)); // number of page , number of item
        }
        public async Task<ActionResult> Search(string search, int? i)
        {
            search = search.Trim();
            ViewBag.SearchTerm=search;
            var Actors = await context.Actors.Where(x => SqlFunctions.PatIndex("%"+ search + "%",x.FullName)>0|| search == null).ToListAsync();
            return View("index", Actors.ToPagedList(i??1,3));
        }
    }
}