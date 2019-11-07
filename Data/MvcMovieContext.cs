using Microsoft.EntityFrameworkCore;
using dotnet_mvc_tut.Models;

namespace dotnet_mvc_tut.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {}

        public DbSet<Movie> Movie {get;set;}
    }
}