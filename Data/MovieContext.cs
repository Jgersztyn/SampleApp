using Microsoft.EntityFrameworkCore;
using SampleApp.Models;

namespace SampleApp.Data
{
    public class SampleAppContext : DbContext
    {
        public SampleAppContext(DbContextOptions<SampleAppContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}