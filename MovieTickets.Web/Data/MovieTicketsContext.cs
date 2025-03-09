using Microsoft.EntityFrameworkCore;
using MovieTickets.Web.Models;

namespace MovieTickets.Web.Data
{
    public class MovieTicketsContext : DbContext
    {
        public MovieTicketsContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(em => new
            {
                em.ActorId,
                em.MovieId,
            });

            //===================================== Data Seeding =================================


            // Seed Data with Validation


            modelBuilder.Entity<Cinema>().HasData(
                new Cinema { Id = 1, Name = "Cinema 1", Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg", Description = "This is the description of the first cinema" },
                new Cinema { Id = 2, Name = "Cinema 2", Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg", Description = "This is the description of the second cinema" }
            );




            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, FullName = "Actor 1", Bio = "This is the Bio of the first actor", ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg" },
                new Actor { Id = 2, FullName = "Actor 2", Bio = "This is the Bio of the second actor", ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg" }
            );



            modelBuilder.Entity<Producer>().HasData(
                new Producer { Id = 1, FullName = "Producer 1", Bio = "This is the Bio of the first producer", ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg" }
            );



            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "Life", Description = "This is the Life movie description", Price = 39.50, ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(10), CinemaId = 1, ProducerId = 1, MovieCategory = MovieCategory.Documentary },

                new Movie { Id = 2, Name = "Death", Description = "This is the Life movie description", Price = 39.50, ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg", StartDate = DateTime.Now.AddDays(-10), EndDate = DateTime.Now.AddDays(10), CinemaId = 1, ProducerId = 1, MovieCategory = MovieCategory.Documentary }
            );

            modelBuilder.Entity<Actor_Movie>().HasData(
                new Actor_Movie { ActorId = 1, MovieId = 1 },
                new Actor_Movie { ActorId = 2, MovieId = 1 }
            );


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
