using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DesignTest.Models
{
    public partial class CarPoolDB : DbContext
    {
        public CarPoolDB()
        {
        }

        public CarPoolDB(DbContextOptions<CarPoolDB> options)
            : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Useer> Useers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ELTE\\MyGitHub\\cs-web-app\\DesignTest\\database.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.ToTable("booking");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RouteId).HasColumnName("route_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__booking__route_i__4E88ABD4");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__booking__user_id__4F7CD00D");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.ToTable("route");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FromCity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("from_city");

                entity.Property(e => e.Km).HasColumnName("km");

                entity.Property(e => e.Seats).HasColumnName("seats");

                entity.Property(e => e.ToCity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("to_city");

                entity.Property(e => e.When)
                    .HasColumnType("datetime")
                    .HasColumnName("when");
            });

            modelBuilder.Entity<Useer>(entity =>
            {
                entity.ToTable("useer");

                entity.HasIndex(e => e.Username, "UQ__useer__F3DBC572E39A754A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
