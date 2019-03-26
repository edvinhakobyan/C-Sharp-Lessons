using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ITVDN_Webinar.Models
{
    public partial class MydbContext : DbContext
    {
        public MydbContext()
        {
        }

        public MydbContext(DbContextOptions<MydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Humen> Humen { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Mydb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.HumenId).HasColumnName("HumenID");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.HasOne(d => d.Humen)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.HumenId)
                    .HasConstraintName("FK__Company__HumenID__2A4B4B5E");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Company)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK__Company__OwnerID__29572725");
            });

            modelBuilder.Entity<Humen>(entity =>
            {
                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.HasOne(d => d.CompanyNavigation)
                    .WithMany(p => p.OwnerNavigation)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Owner__CompanyId__276EDEB3");
            });
        }
    }
}
