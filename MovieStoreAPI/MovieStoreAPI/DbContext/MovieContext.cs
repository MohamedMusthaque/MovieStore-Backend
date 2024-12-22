namespace MovieStoreAPI.DbContext
{
    using Microsoft.EntityFrameworkCore;
    using MovieStoreAPI.Models;

    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}
