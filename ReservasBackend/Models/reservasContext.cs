using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ReservasBackend.Models
{
    public partial class reservasContext : DbContext
    {
        public reservasContext()
        {
        }

        public reservasContext(DbContextOptions<reservasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CupoSedeAlojamiento> CupoSedeAlojamiento { get; set; }
        public virtual DbSet<Sede> Sede { get; set; }
        public virtual DbSet<TipoAlojamiento> TipoAlojamiento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=DESKTOP-R8OU92F\\SQLEXPRESS; initial catalog=reservas; user=sa; password=1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CupoSedeAlojamiento>(entity =>
            {
                entity.ToTable("cupo_sede_alojamiento");

                entity.Property(e => e.CupoSedeAlojamientoId).HasColumnName("cupo_sede_alojamiento_id");

                entity.Property(e => e.NumeroHabiaciones)
                    .HasColumnName("numero_habiaciones")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SedeId).HasColumnName("sede_id");

                entity.Property(e => e.TipoAlojamientoId).HasColumnName("tipo_alojamiento_id");

                entity.HasOne(d => d.Sede)
                    .WithMany(p => p.CupoSedeAlojamiento)
                    .HasForeignKey(d => d.SedeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cupo_sede_alojamiento2_sede");

                entity.HasOne(d => d.TipoAlojamiento)
                    .WithMany(p => p.CupoSedeAlojamiento)
                    .HasForeignKey(d => d.TipoAlojamientoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cupo_sede_alojamiento2_tipo_alojamiento");
            });

            modelBuilder.Entity<Sede>(entity =>
            {
                entity.ToTable("sede");

                entity.Property(e => e.SedeId).HasColumnName("sede_id");

                entity.Property(e => e.SedeCupoMax)
                    .HasColumnName("sede_cupo_max")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SedeNombre)
                    .IsRequired()
                    .HasColumnName("sede_nombre")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TipoAlojamiento>(entity =>
            {
                entity.ToTable("tipo_alojamiento");

                entity.Property(e => e.TipoAlojamientoId).HasColumnName("tipo_alojamiento_id");

                entity.Property(e => e.TipoAlojamientoNombre)
                    .HasColumnName("tipo_alojamiento_nombre")
                    .HasMaxLength(10);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
