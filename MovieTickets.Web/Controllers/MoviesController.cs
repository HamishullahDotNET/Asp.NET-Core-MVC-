using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTickets.Web.Data;
using MovieTickets.Web.Models;

namespace MovieTickets.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieTicketsContext _db;
        public MoviesController(MovieTicketsContext db)
        {
            _db = db;
        }

        // Acitons

        public async Task<IActionResult> Index()
        {
            List<Movie> movies = await _db.Movies.Include(c => c.Cinema).Include(p => p.Producer).ToListAsync();
            return View(movies);
        }





    }
}
