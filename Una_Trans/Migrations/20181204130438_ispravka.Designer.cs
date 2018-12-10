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
    [Migration("20181204130438_ispravka")]
    partial class ispravka
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<float>("Cijena");

                    b.Property<string>("DatumPolaskaRedVoznje");

                    b.Property<int>("KartaId");

                    b.Property<int>("OdredisteId");

                    b.Property<int>("PolazisteId");

                    b.Property<string>("VrijemeDolaskaRedVoznje");

                    b.Property<string>("VrijemePolaskaRedVoznje");

                    b.HasKey("Id");

                    b.HasIndex("KartaId");

                    b.HasIndex("OdredisteId");

                    b.HasIndex("PolazisteId");

                    b.ToTable("RedVoznje");
                });

            modelBuilder.Entity("Una_Trans.Models.Rezervacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DatumPolaskaRezervacija");

                    b.Property<int>("KartaRezervacijaId");

                    b.Property<int>("OdredisteRezervacijaId");

                    b.Property<int>("PolazisteRezervacijaId");

                    b.Property<string>("VrijemeDolaskaRezervacija");

                    b.Property<string>("VrijemePolaskaRezervacija");

                    b.HasKey("Id");

                    b.HasIndex("KartaRezervacijaId");

                    b.HasIndex("OdredisteRezervacijaId");

                    b.HasIndex("PolazisteRezervacijaId");

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

                    b.Property<string>("RutaPutovanja");

                    b.Property<string>("Telefon");

                    b.Property<string>("VrijemeDolaska");

                    b.Property<string>("VrijemePolaska");

                    b.Property<int>("ZakupGradId");

                    b.HasKey("Id");

                    b.HasIndex("ZakupGradId");

                    b.ToTable("ZakupAutobusa");
                });

            modelBuilder.Entity("Una_Trans.Models.RedVoznje", b =>
                {
                    b.HasOne("Una_Trans.Models.Karta", "Karta")
                        .WithMany()
                        .HasForeignKey("KartaId")
                        .OnDelete(DeleteBehavior.Cascade);

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
                    b.HasOne("Una_Trans.Models.Karta", "KartaRezervacija")
                        .WithMany()
                        .HasForeignKey("KartaRezervacijaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Una_Trans.Models.Grad", "OdredisteRezervacija")
                        .WithMany()
                        .HasForeignKey("OdredisteRezervacijaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Una_Trans.Models.Grad", "PolazisteRezervacija")
                        .WithMany()
                        .HasForeignKey("PolazisteRezervacijaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Una_Trans.Models.ZakupAutobusa", b =>
                {
                    b.HasOne("Una_Trans.Models.Grad", "ZakupGrad")
                        .WithMany()
                        .HasForeignKey("ZakupGradId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
