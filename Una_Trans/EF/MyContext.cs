using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Una_Trans.EntityModels;
using Una_Trans.Models;

namespace Una_Trans.EF
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> x) : base(x)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RedVoznje>().HasOne(a => a.Polaziste).WithMany().HasForeignKey(a => a.PolazisteId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<RedVoznje>().HasOne(a => a.Odrediste).WithMany().HasForeignKey(a => a.OdredisteId).OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<Rezervacija>().HasOne(a => a.PolazisteRezervacija).WithMany().HasForeignKey(a => a.PolazisteRezervacijaId).OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<Rezervacija>().HasOne(a => a.OdredisteRezervacija).WithMany().HasForeignKey(a => a.OdredisteRezervacijaId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ZakupAutobusa>().HasOne(a => a.ZakupGrad).WithMany().HasForeignKey(a => a.ZakupGradId).OnDelete(DeleteBehavior.Restrict);

            

        }
        public DbSet<Karta> Karta { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Rezervacija> Rezervacija { get; set; }
        public DbSet<RedVoznje> RedVoznje { get; set; }
        public DbSet<ZakupAutobusa> ZakupAutobusa { get; set; }
        public DbSet<KartaCijena> KartaCijena { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
    }
}
