using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MovieTickets.Web.Data;

namespace MovieTickets.Web.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        [DisplayName("Image")]
        public string ImageURL { get; set; }

        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        // Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cenima
        public int CinemaId { get; set; }

        public Cinema Cinema { get; set; }

        // Producer
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
    }
}
