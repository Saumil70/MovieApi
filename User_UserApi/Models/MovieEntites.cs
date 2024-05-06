
using Microsoft.EntityFrameworkCore;

namespace User_UserApi.Models
{
    public class MovieEntites : DbContext

    {
        public MovieEntites(DbContextOptions<MovieEntites> options) : base(options) 
        {
            
        }

     

        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<BookingDetails> BookingDetails { get; set; }

        public DbSet<Countries> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
