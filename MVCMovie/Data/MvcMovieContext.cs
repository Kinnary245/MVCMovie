using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MVCMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext()
        {
        }

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}