using EmpresaMusical.Domain.Entities;
using EmpresaMusical.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated(); // Cria o banco de dados caso não exista
        }

        public DbSet<Instrumento> Instrumentos { get; set; }
        public DbSet<Musico> Musicos { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Musica> Musicas { get; set; }
        public DbSet<MusicoInstrumento> MusicoInstrumentos {  get; set; }
        public DbSet<MusicoAlbum> MusicoAlbums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Instrumento>(new InstrumentoMap().Configure);
            modelBuilder.Entity<Musico>(new MusicoMap().Configure);
            modelBuilder.Entity<Album>(new AlbumMap().Configure);
            modelBuilder.Entity<Musica>(new MusicaMap().Configure);
            modelBuilder.Entity<MusicoInstrumento>(new MusicoInstrumentoMap().Configure);
            modelBuilder.Entity<MusicoAlbum>(new MusicoAlbumMap().Configure);
        }

    }
}
