﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Una_Trans.EF;

namespace Una_Trans.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20181209211628_kkkk1")]
    partial class kkkk1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Una_Trans.EntityModels.KartaCijena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cijena");

                    b.Property<int>("CijenaKartaId");

                    b.Property<int>("CijenaRedVoznjeId");

                    b.HasKey("Id");

                    b.HasIndex("CijenaKartaId");

                    b.HasIndex("CijenaRedVoznjeId");

                    b.ToTable("KartaCijena");
                });

            modelBuilder.Entity("Una_Trans.EntityModels.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime");

                    b.Property<string>("Prezime");

                    b.Property<string>("email");

                    b.Property<string>("lozinka");

                    b.HasKey("Id");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Una_Trans.Models.Grad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("Una_Trans.Models.Karta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Karta");
                });

            modelBuilder.Entity("Una_Trans.Models.RedVoznje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DatumPolaskaRedVoznje");

                    b.Property<int>("OdredisteId");

                    b.Property<int>("PolazisteId");

                    b.Property<string>("VrijemeDolaskaRedVoznje");

                    b.Property<string>("VrijemePolaskaRedVoznje");

                    b.HasKey("Id");

                    b.HasIndex("OdredisteId");

                    b.HasIndex("PolazisteId");

                    b.ToTable("RedVoznje");
                });

            modelBuilder.Entity("Una_Trans.Models.Rezervacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KartaCijenaId");

                    b.Property<int>("KorisnikRezervacijaId");

                    b.HasKey("Id");

                    b.HasIndex("KartaCijenaId");

                    b.HasIndex("KorisnikRezervacijaId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("Una_Trans.Models.ZakupAutobusa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdresaPolaska");

                    b.Property<int>("BrojPutnika");

                    b.Property<string>("DatumDolaska");

                    b.Property<string>("DatumPolaska");

                    b.Property<string>("Email");

                    b.Property<string>("ImePrezimeFirma");

                    b.Property<string>("JMBG");

                    b.Property<int>("KorisnikZakupId");

                    b.Property<string>("RutaPutovanja");

                    b.Property<string>("Telefon");

                    b.Property<string>("VrijemeDolaska");

                    b.Property<string>("VrijemePolaska");

                    b.Property<int>("ZakupGradId");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikZakupId");

                    b.HasIndex("ZakupGradId");

                    b.ToTable("ZakupAutobusa");
                });

            modelBuilder.Entity("Una_Trans.EntityModels.KartaCijena", b =>
                {
                    b.HasOne("Una_Trans.Models.Karta", "CijenaKarta")
                        .WithMany()
                        .HasForeignKey("CijenaKartaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Una_Trans.Models.RedVoznje", "CijenaRedVoznje")
                        .WithMany()
                        .HasForeignKey("CijenaRedVoznjeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Una_Trans.Models.RedVoznje", b =>
                {
                    b.HasOne("Una_Trans.Models.Grad", "Odrediste")
                        .WithMany()
                        .HasForeignKey("OdredisteId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Una_Trans.Models.Grad", "Polaziste")
                        .WithMany()
                        .HasForeignKey("PolazisteId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Una_Trans.Models.Rezervacija", b =>
                {
                    b.HasOne("Una_Trans.EntityModels.KartaCijena", "KartaCijena")
                        .WithMany()
                        .HasForeignKey("KartaCijenaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Una_Trans.EntityModels.Korisnik", "KorisnikRezervacija")
                        .WithMany()
                        .HasForeignKey("KorisnikRezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Una_Trans.Models.ZakupAutobusa", b =>
                {
                    b.HasOne("Una_Trans.EntityModels.Korisnik", "KorisnikZakup")
                        .WithMany()
                        .HasForeignKey("KorisnikZakupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Una_Trans.Models.Grad", "ZakupGrad")
                        .WithMany()
                        .HasForeignKey("ZakupGradId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
