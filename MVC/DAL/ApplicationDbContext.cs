using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<City> Cities{ get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<Representation> Representations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(x =>
            {
                x.HasKey(x => x.CityId);
                x.HasMany(y => y.Representations).WithOne(x => x.City).HasForeignKey(x => x.RepresentationId);
            });

            modelBuilder.Entity<Personnel>(x =>
            {
                x.HasOne(x => x.Representation).WithMany(x => x.Personnels).HasForeignKey(x => x.RepresentationId);
            });
        }
    }
}
