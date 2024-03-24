using HRTechAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace HRTechAPI
{
    public class UygulamaDbContext: DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options)
    : base(options)
        {
        }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Sirket> Sirketler { get; set; }
        public DbSet<Meslek> Meslekler { get; set; }
        public DbSet<Departman> Departmanlar { get; set; }
        public DbSet<Adres> Adresler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>()
                .Property(p => p.Maas)
                .HasColumnType("decimal(18,2)");
        }

    }
}
