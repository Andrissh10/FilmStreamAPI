using FilmStreamAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilmStreamAPI.Context
{
    public class FilmstreamingContext : DbContext
    {
        public FilmstreamingContext(DbContextOptions<FilmstreamingContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Film> Films { get; set; }
    }
}
