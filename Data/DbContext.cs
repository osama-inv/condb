using condb.Models;
using Microsoft.EntityFrameworkCore;

namespace condb.Data
{
    public class TheDbContext : DbContext
    {
        public TheDbContext(DbContextOptions<TheDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> people { get; set; }
    }
}
