using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Web.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }

        // ✅ One-to-Many Relationship
        public List<Movie> Movies { get; set; }
        //public int Id { get; set; }

        //public string Logo { get; set; }
        //public string Name { get; set; }
        //public string Description { get; set; }

        //// Relationships
        //public List<Movie> Movies { get; set; }


    }
}
