using System;
using MeusLivrosAPI.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MeusLivrosAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livros_Autor>()
                .HasOne(b => b.Livros)
                .WithMany(ba => ba.Livros_Autors)
                .HasForeignKey(bi => bi.LivrosId);

            modelBuilder.Entity<Livros_Autor>()
                .HasOne(b => b.Autor)
                .WithMany(ba => ba.Livros_Autors)
                .HasForeignKey(bi => bi.AutorId);


        }

        public DbSet<Livros> Livros { get; set; }

        public DbSet<Autor> Autors { get; set; }

        public DbSet<Livros_Autor> Livros_Autors { get; set; }

        public DbSet<Publicar> Publicars { get; set; }
    }
}
