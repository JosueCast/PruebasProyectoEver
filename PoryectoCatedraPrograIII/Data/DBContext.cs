using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using PoryectoCatedraPrograIII.Models;

namespace PoryectoCatedraPrograIII.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Tiendas> Tiendas { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Resena> Resenas { get; set; }
        public DbSet<ElementoGuardado> ElementosGuardados { get; set; }
        public DbSet<Promocion> Promociones { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Evento> Eventos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>()
           .HasMany(u => u.Tiendas)
           .WithOne(t => t.Usuarios)
           .HasForeignKey(t => t.UsuarioId);

            modelBuilder.Entity<Usuarios>()
                .HasMany(u => u.Resenas)
                .WithOne(r => r.Usuario)
                .HasForeignKey(r => r.UsuarioId);

            modelBuilder.Entity<Usuarios>()
                .HasMany(u => u.ElementosGuardados)
                .WithOne(e => e.Usuario)
                .HasForeignKey(e => e.UsuarioId);

            modelBuilder.Entity<Tiendas>()
                .HasMany(t => t.Productos)
                .WithOne(p => p.Tienda)
                .HasForeignKey(p => p.TiendaId);

            modelBuilder.Entity<Tiendas>()
                .HasMany(t => t.Servicios)
                .WithOne(s => s.Tienda)
                .HasForeignKey(s => s.TiendaId);

            modelBuilder.Entity<Tiendas>()
                .HasMany(t => t.Promociones)
                .WithOne(p => p.Tienda)
                .HasForeignKey(p => p.TiendaId);

            modelBuilder.Entity<Tiendas>()
                .HasMany(t => t.Resenas)
                .WithOne(r => r.Tienda)
                .HasForeignKey(r => r.TiendaId);
        }
    }
}

