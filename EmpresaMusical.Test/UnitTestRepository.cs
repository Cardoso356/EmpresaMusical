using EmpresaMusical.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Bson;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmpresaMusical.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Instrumento> Instrumentos { get; set; }
            public DbSet<Musico> Musicos { get; set; }
            public DbSet<Album> Albums { get; set; }
            public DbSet<Musica> Musicas { get; set; }
            public DbSet<MusicoInstrumento> MusicoInstrumentos { get; set; }
            public DbSet<MusicoAlbum> MusicoAlbums { get; set; }


            public MyDbContext() 
            { 
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "EmpresaMusical";
                var username = "root";
                var password = "ifsp"; //senha do mySqlWorkbench
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }


        [TestMethod]
        public void TestInsertInstrumentos()  //inserção no banco de dados
        {
            using (var context = new MyDbContext())
            {

                var instrumento = new Instrumento
                {
                    NomeInstrumento = "Piano",
                    Tipo = "Percussao"
                };
                context.Instrumentos.Add(instrumento);

                instrumento = new Instrumento
                {
                    NomeInstrumento = "Flauta",
                    Tipo = "Sopro"
                };
                context.Instrumentos.Add(instrumento);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListInstrumentos() // listagem dos dados
        {
            using (var context = new MyDbContext())
            {
                foreach (var instrumento in context.Instrumentos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(instrumento));
                }
            }
        }


        [TestMethod]
        public void TestInsertMusicos() //inserção no banco de dados
        {
            using (var context = new MyDbContext())
            {

                var musico = new Musico
                {
                    NomeMusico = "Corey Taylor",
                    Endereco = "Rua dos Mais Fodas - Los Angeles",
                    Email = "coreyTaylorSlipknot@gmail.com",
                    Telefone = "123-456"
                };
                context.Musicos.Add(musico);

                musico = new Musico
                {
                    NomeMusico = "Michael Jackson",
                    Endereco = "Rancho Neverland - Los Angeles",
                    Email = "Rusbe@gmail.com",
                    Telefone = "654-321"
                };
                context.Musicos.Add(musico);

                context.SaveChanges();
            }
        }


        [TestMethod]
        public void TestListMusicos() // listagem dos dados
        {
            using (var context = new MyDbContext())
            {
                foreach (var musico in context.Musicos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(musico));
                }
            }
        }


        [TestMethod]
        public void TestInsertAlbuns() //inserção no banco de dados
        {
            using(var context = new MyDbContext())
            {
                var album = new Album
                {
                    TituloAlbum = "All Hope is Gone",
                    Formato = "CD",
                    Data = new DateTime(2008, 08, 26)
                };
                context.Albums.Add(album);

                album = new Album
                {
                    TituloAlbum = "Thriller",
                    Formato = "Disco de vinil",
                    Data = new DateTime(1982, 11, 30)
                };
                context.Albums.Add(album);

                context.SaveChanges();
            }
        }


        [TestMethod]
        public void TestListAlbuns() // listagem dos dados
        {
            using(var context = new MyDbContext())
            {
                foreach(var album in context.Albums)
                {
                    Console.WriteLine(JsonSerializer.Serialize(album));
                }
            }
        }


        [TestMethod]
        public void TestInsertMusicas() //inserção no banco de dados
        {
            using (var context = new MyDbContext())
            {
                var album = context.Albums.FirstOrDefault(prop => prop.Id == 1); //musica depende de album

                var musica = new Musica
                {
                    NomeMusica = "Dead Memories",
                    Gravadora = "Roadrunner Records",
                    Album = album
                };
                context.Musicas.Add(musica);


                album = context.Albums.FirstOrDefault(prop => prop.Id == 2); //musica depende de album

                musica = new Musica
                {
                    NomeMusica = "Beat It",
                    Gravadora = "Epic Records",
                    Album = album
                };
                context.Musicas.Add(musica);

                context.SaveChanges();
            }
        }


        [TestMethod]
        public void TestListMusicas() // listagem dos dados
        {
            using (var context = new MyDbContext())
            {
                foreach (var musica in context.Musicas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(musica));
                }
            }
        }


        [TestMethod]
        public void TestInsertMusicosInstrumentos() //inserção no banco de dados
        {
            using (var context = new MyDbContext())
            {
                var musico = context.Musicos.FirstOrDefault(prop => prop.Id == 1); //musicaInstrumento depende de musico
                var instrumento = context.Instrumentos.FirstOrDefault(prop => prop.Id == 1); //musicaInstrumento depende de instrumento

                var musicoInstrumento = new MusicoInstrumento
                {
                    Musico = musico,
                    Instrumento = instrumento
                };
                context.MusicoInstrumentos.Add(musicoInstrumento);


                musico = context.Musicos.FirstOrDefault(prop => prop.Id == 2); //musicaInstrumento depende de musico
                instrumento = context.Instrumentos.FirstOrDefault(prop => prop.Id == 2); //musicaInstrumento depende de instrumento

                musicoInstrumento = new MusicoInstrumento
                {
                    Musico = musico,
                    Instrumento = instrumento
                };
                context.MusicoInstrumentos.Add(musicoInstrumento);

                context.SaveChanges();
            }
        }


        [TestMethod]
        public void TestListMusicosInstrumentos() // listagem dos dados
        {
            using (var context = new MyDbContext())
            {
                foreach (var musicoInstrumento in context.MusicoInstrumentos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(musicoInstrumento));
                }
            }
        }


        [TestMethod]
        public void TestInsertMusicosAlbuns() //inserção no banco de dados
        {
            using (var context = new MyDbContext())
            {
                var musico = context.Musicos.FirstOrDefault(prop => prop.Id == 1); //musicoAlbum depende de musico
                var album = context.Albums.FirstOrDefault(prop => prop.Id == 1); //musicoAlbum depende do album

                var musicoAlbum = new MusicoAlbum
                {
                    Musico = musico,
                    Album = album
                };
                context.MusicoAlbums.Add(musicoAlbum);


                musico = context.Musicos.FirstOrDefault(prop => prop.Id == 2); //musicaInstrumento depende de musico
                album = context.Albums.FirstOrDefault(prop => prop.Id == 2); //musicaInstrumento depende de album

                musicoAlbum = new MusicoAlbum
                {
                    Musico = musico,
                    Album = album
                };
                context.MusicoAlbums.Add(musicoAlbum);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListMusicosAlbuns() // listagem dos dados
        {
            using (var context = new MyDbContext())
            {
                foreach (var musicoAlbum in context.MusicoAlbums)
                {
                    Console.WriteLine(JsonSerializer.Serialize(musicoAlbum));
                }
            }
        }






    }
}
