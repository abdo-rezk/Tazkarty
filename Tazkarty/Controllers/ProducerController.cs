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
    public class ProducerController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        // GET: Producer
        public async Task<ActionResult> Index(int?i)
        {
            Session["ControlName"] = "Producer";
            var Producers =await context.Producers.ToListAsync();
            return View(Producers.ToPagedList(i ?? 1, 3));
        }
        public async Task<ActionResult> Search(string search, int? i)
        {
            search = search.Trim();
            ViewBag.SearchTerm = search;
            var producers = await context.Producers.Where(x => SqlFunctions.PatIndex("%" + search + "%", x.FullName) > 0 || search == null).ToListAsync();
            return View("index", producers.ToPagedList(i ?? 1, 3));
        }
    }
}