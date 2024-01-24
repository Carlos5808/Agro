using Agro.web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Agro.web.Data
{
    public class DataContext DataContext : DbContext
    {
        DbSet<City> Cities { get; set; }
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {

        }

    protected override void OnModelCreating(ModelBuildermodeBuilder)
    {
        base.OnModelCreating(modelBuilder);
        ModelBuilder.Entity<City>().HasIndex(xx.Name).IsUnique();
    }
    }
}
