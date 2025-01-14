using Lexicon_To_do_List.Models;
using Microsoft.EntityFrameworkCore;

namespace Lexicon_To_do_List
{
    public class CatalogueContext : DbContext
    {
        public CatalogueContext(DbContextOptions<CatalogueContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
