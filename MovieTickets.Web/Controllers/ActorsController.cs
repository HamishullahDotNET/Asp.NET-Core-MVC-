using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTickets.Web.Data;
using MovieTickets.Web.Models;

namespace MovieTickets.Web.Controllers
{
    [Route("Actors")]
    public class ActorsController : Controller
    {

        // Db Context Class Inject Here 

        private readonly MovieTicketsContext _db;
        public ActorsController(MovieTicketsContext db)
        {
            _db = db;

        }


        // My Actions for The Actor Model

        [Route("Actors")]
        public async Task<IActionResult> Index()
        {
            List<Actor> actors = await _db.Actors.ToListAsync();
            return View(actors);
        }

        //==============================================












































    }
}
