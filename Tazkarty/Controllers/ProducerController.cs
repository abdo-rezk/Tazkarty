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
    public class ProducerController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        // GET: Producer
        public async Task<ActionResult> Index()
        {
            var Producers =await context.Actors.ToListAsync();
            return View(Producers);
        }
    }
}