using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTickets.Web.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public string? FeatureImage { get; set; }
        public IFormFile MovieImage { get; }


        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
