using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public async Task<ActionResult> Index()
        {
            var Movies = await context.Actors.ToListAsync();
            return View();
        }
    }
}