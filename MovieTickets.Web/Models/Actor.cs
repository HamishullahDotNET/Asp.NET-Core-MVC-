using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Web.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
