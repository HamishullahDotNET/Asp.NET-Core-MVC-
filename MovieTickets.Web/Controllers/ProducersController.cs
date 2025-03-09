
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTickets.Web.Data;
using MovieTickets.Web.Models;

namespace MovieTickets.Web.Controllers
{
    public class ProducersController : Controller
    {
        // Db Context Class Inject Here 

        private readonly MovieTicketsContext _db;
        public ProducersController(MovieTicketsContext db)
        {
            _db = db;

        }


        // My Actions for The Actor Model


        public async Task<IActionResult> Index()
        {
            List<Producer> producers = await _db.Producers.ToListAsync();
            return View(producers);
        }

        //==============================================





    }
}
