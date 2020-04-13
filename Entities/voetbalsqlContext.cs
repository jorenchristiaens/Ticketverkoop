using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ticketverkoop_Beter.Entities
{
    public partial class voetbalsqlContext : DbContext
    {
        public voetbalsqlContext()
        {
        }

        public voetbalsqlContext(DbContextOptions<voetbalsqlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbbonnementKlant> AbbonnementKlant { get; set; }
        public virtual DbSet<Abbonnementen> Abbonnementen { get; set; }
        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<Gemeente> Gemeente { get; set; }
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<Sectie> Sectie { get; set; }
        public virtual DbSet<Stadion> Stadion { get; set; }
        public virtual DbSet<Ticket> Ticket { get; set; }
        public virtual DbSet<Zitje> Zitje { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQL_VIVES; Database=voetbalsql;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AbbonnementKlant>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GeldigVan)
                    .HasColumnName("geldigVan")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAbbonnement).HasColumnName("idAbbonnement");

                entity.Property(e => e.IdClub).HasColumnName("idClub");

                entity.HasOne(d => d.IdAbbonnementNavigation)
                    .WithMany(p => p.AbbonnementKlant)
                    .HasForeignKey(d => d.IdAbbonnement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKAbbonnemen747396");

                entity.HasOne(d => d.IdClubNavigation)
                    .WithMany(p => p.AbbonnementKlant)
                    .HasForeignKey(d => d.IdClub)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKAbbonnemen298203");
            });

            modelBuilder.Entity<Abbonnementen>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GeldijgheidTermijn).HasColumnName("geldijgheidTermijn");

                entity.Property(e => e.NaamAbbonnement)
                    .HasColumnName("naamAbbonnement")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Voorwaarden)
                    .HasColumnName("voorwaarden")
                    .HasMaxLength(2048)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Club>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdThuisstadion).HasColumnName("idThuisstadion");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NaamClub)
                    .HasColumnName("naamClub")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdThuisstadionNavigation)
                    .WithMany(p => p.Club)
                    .HasForeignKey(d => d.IdThuisstadion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKClub884630");
            });

            modelBuilder.Entity<Gemeente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NaamGemeente)
                    .HasColumnName("naamGemeente")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .HasColumnName("postcode")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Match>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DatumMatch)
                    .HasColumnName("datumMatch")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdStadion).HasColumnName("idStadion");

                entity.Property(e => e.IdUitClub).HasColumnName("idUitClub");

                entity.Property(e => e.Seizoen).HasColumnName("seizoen");

                entity.Property(e => e.StartTijd)
                    .HasColumnName("startTijd")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdStadionNavigation)
                    .WithMany(p => p.Match)
                    .HasForeignKey(d => d.IdStadion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch385811");

                entity.HasOne(d => d.IdUitClubNavigation)
                    .WithMany(p => p.Match)
                    .HasForeignKey(d => d.IdUitClub)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKMatch867807");
            });

            modelBuilder.Entity<Sectie>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AantalPlaatsen).HasColumnName("aantalPlaatsen");

                entity.Property(e => e.Idstadion).HasColumnName("idstadion");

                entity.Property(e => e.NaamSectie)
                    .HasColumnName("naamSectie")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PrijsAbbonnement).HasColumnName("prijsAbbonnement");

                entity.Property(e => e.PrijsTicket).HasColumnName("prijsTicket");

                entity.HasOne(d => d.IdstadionNavigation)
                    .WithMany(p => p.Sectie)
                    .HasForeignKey(d => d.Idstadion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKSectie177067");
            });

            modelBuilder.Entity<Stadion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HuisNr).HasColumnName("huisNr");

                entity.Property(e => e.IdGemeente).HasColumnName("idGemeente");

                entity.Property(e => e.NaamStadion)
                    .HasColumnName("naamStadion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Straat)
                    .HasColumnName("straat")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGemeenteNavigation)
                    .WithMany(p => p.Stadion)
                    .HasForeignKey(d => d.IdGemeente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKStadion800613");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdZitje).HasColumnName("idZitje");

                entity.HasOne(d => d.IdZitjeNavigation)
                    .WithMany(p => p.Ticket)
                    .HasForeignKey(d => d.IdZitje)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKTicket849515");
            });

            modelBuilder.Entity<Zitje>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdMatch).HasColumnName("idMatch");

                entity.Property(e => e.IdSectie).HasColumnName("idSectie");

                entity.HasOne(d => d.IdMatchNavigation)
                    .WithMany(p => p.Zitje)
                    .HasForeignKey(d => d.IdMatch)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKZitje117038");

                entity.HasOne(d => d.IdSectieNavigation)
                    .WithMany(p => p.Zitje)
                    .HasForeignKey(d => d.IdSectie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKZitje29983");
            });
        }
    }
}
