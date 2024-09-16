using Microsoft.EntityFrameworkCore;
using Practica.Dominio.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Persistencia.Context
{
    public partial class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext()
        {
        }

        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__books__3213E83FDC6E1654");

                entity.ToTable("books");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Author)
                    .HasMaxLength(255)
                    .HasColumnName("author");
                entity.Property(e => e.Available).HasColumnName("available");
                entity.Property(e => e.Genre)
                    .HasMaxLength(100)
                    .HasColumnName("genre");
                entity.Property(e => e.PublishedYear).HasColumnName("published_year");
                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
