using JveJcilarDBupdate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JveJcilarDBupdate.Data
{
    public class CafeContext : DbContext
    {
        public CafeContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=JveJDB;Integrated Security=True;");
            }
        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Kategori> KafeBilgileri { get; set; }
        public DbSet<Kategori> Katlar { get; set; }
        public DbSet<Kategori> Urunler { get; set; }
        public DbSet<Kategori> Siparisler { get; set; }
        public DbSet<Kategori> Masalar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>()
                .Property(x => x.Fiyat)
                .HasPrecision(10, 2);
            modelBuilder.Entity<Siparis>()
                .Property(x => x.Fiyat)
                .HasPrecision(10, 2);
            modelBuilder.Entity<Siparis>()
                .HasKey(x => new { x.MasaId, x.UrunId });
        }
    }
}
