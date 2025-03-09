using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTickets.Web.Data;
using MovieTickets.Web.Models;

namespace MovieTickets.Web.Controllers
{
    public class CinemasController : Controller
    {

        // Db Context Class Inject Here 

        private readonly MovieTicketsContext _db;
        public CinemasController(MovieTicketsContext db)
        {
            _db = db;

        }


        // My Actions for The Actor Model

        public async Task<IActionResult> Index()
        {
            List<Cinema> cinemas = await _db.Cinemas.ToListAsync();
            return View(cinemas);
        }

    }
}
