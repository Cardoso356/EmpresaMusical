using AutoMapper;
using EmpresaMusical.Domain.Base;
using EmpresaMusical.Domain.Entities;
using EmpresaMusical.Repository.Context;
using EmpresaMusical.Repository.Repository;
using EmpresaMusical.Service.Services;
using EmpresaMusical.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.DependencyInjection;
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
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "EmpresaMusical"; //o banco de dados
                var username = "root";
                var password = "ifsp"; //senha do mySqlWorkbench
                var strCon = $"Server={server};Port={port};Database={database};" +
                            $"Uid={username};Pwd={password}";
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Instrumento>, BaseRepository<Instrumento>>();
            services.AddScoped<IBaseService<Instrumento>, BaseService<Instrumento>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Instrumento, Instrumento>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Musico>, BaseRepository<Musico>>();
            services.AddScoped<IBaseService<Musico>, BaseService<Musico>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Musico, Musico>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Album>, BaseRepository<Album>>();
            services.AddScoped<IBaseService<Album>, BaseService<Album>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Album, Album>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<Musica>, BaseRepository<Musica>>();
            services.AddScoped<IBaseService<Musica>, BaseService<Musica>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Musica, Musica>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<MusicoInstrumento>, BaseRepository<MusicoInstrumento>>();
            services.AddScoped<IBaseService<MusicoInstrumento>, BaseService<MusicoInstrumento>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<MusicoInstrumento, MusicoInstrumento>();
            }).CreateMapper());

            services.AddScoped<IBaseRepository<MusicoAlbum>, BaseRepository<MusicoAlbum>>();
            services.AddScoped<IBaseService<MusicoAlbum>, BaseService<MusicoAlbum>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<MusicoAlbum, MusicoAlbum>();
            }).CreateMapper());

            return services.BuildServiceProvider();
        }


        [TestMethod]
        public void TestInsertInstrumento() //insere os dados
        {
            var sp = ConfigureServices();
            var instrumentoService = sp.GetService<IBaseService<Instrumento>>();
            var instrumento = new Instrumento
            {
                NomeInstrumento = "Saxofone",
                Tipo = "Sopro"
            };

            var result = instrumentoService.Add<Instrumento, Instrumento, InstrumentoValidator>(instrumento);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectInstrumento() //lista os dados
        {
            var sp = ConfigureServices();
            var instrumentoService = sp.GetService<IBaseService<Instrumento>>();

            var result = instrumentoService.Get<Instrumento>();
            Console.Write(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestInsertMusico() //insere os dados
        {
            var sp = ConfigureServices();
            var musicoService = sp.GetService<IBaseService<Musico>>();
            var musico = new Musico
            {
                NomeMusico = "Roberto Carlos",
                Endereco = "Rua interna da Rede Globo, nº302",
                Email = "OReiQueCongelaEDescongela@gmail.com",
                Telefone = "991220225",
                Login = "rei",
                Senha = "reizão"
            };

            var result = musicoService.Add<Musico, Musico, MusicoValidator>(musico);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestSelectMusico() //lista os dados
        {
            var sp = ConfigureServices();
            var musicoService = sp.GetService<IBaseService<Musico>>();

            var result = musicoService.Get<Musico>();
            Console.Write(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestInsertAlbum() //insere os dados
        {
            var sp = ConfigureServices();
            var albumService = sp.GetService<IBaseService<Album>>();
            var album = new Album
            {
                TituloAlbum = "Jovem Guarda",
                Formato = "Disco de vinil",
                Data = DateTime.Parse("1965-04-07")
            };

            var result = albumService.Add<Album, Album, AlbumValidator>(album);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectAlbum() //lista os dados
        {
            var sp = ConfigureServices();
            var albumService = sp.GetService<IBaseService<Album>>();

            var result = albumService.Get<Album>();
            Console.Write(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestInsertMusica() //insere os dados
        {
            var sp = ConfigureServices();

            var albumService = sp.GetService<IBaseService<Album>>();
            var album = albumService.Get<Album>().FirstOrDefault(prop => prop.Id == 1);

            var musicaService = sp.GetService<IBaseService<Musica>>();
            var musica = new Musica
            {
                NomeMusica = "Eu te adoro meu amor",
                Gravadora = "CBS",
                Album = album
            };

            var result = musicaService.Add<Musica, Musica, MusicaValidator>(musica);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestSelectMusica() //lista os dados
        {
            var sp = ConfigureServices();
            var musicaService = sp.GetService<IBaseService<Musica>>();

            var result = musicaService.Get<Musica>();
            Console.Write(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestInsertMusicoInstrumento() //insere os dados
        {
            var sp = ConfigureServices();

            var musicoService = sp.GetService<IBaseService<Musico>>();
            var musico = musicoService.Get<Musico>().FirstOrDefault(prop => prop.Id == 1);

            var instrumentoService = sp.GetService<IBaseService<Instrumento>>();
            var instrumento = instrumentoService.Get<Instrumento>().FirstOrDefault(prop => prop.Id == 1);


            var musicoInstrumentoService = sp.GetService<IBaseService<MusicoInstrumento>>();
            var musicoInstrumento = new MusicoInstrumento
            {
                Musico = musico,
                Instrumento = instrumento
            };

            var result = musicoInstrumentoService.Add<MusicoInstrumento, MusicoInstrumento, MusicoInstrumentoValidator>(musicoInstrumento);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestSelectMusicoInstrumento() //lista os dados
        {
            var sp = ConfigureServices();
            var musicoInstrumentoService = sp.GetService<IBaseService<MusicoInstrumento>>();

            var result = musicoInstrumentoService.Get<MusicoInstrumento>();
            Console.Write(JsonSerializer.Serialize(result));
        }


        [TestMethod]
        public void TestInsertMusicoAlbum() //insere os dados
        {
            var sp = ConfigureServices();

            var musicoService = sp.GetService<IBaseService<Musico>>();
            var musico = musicoService.Get<Musico>().FirstOrDefault(prop => prop.Id == 1);

            var albumService = sp.GetService<IBaseService<Album>>();
            var album = albumService.Get<Album>().FirstOrDefault(prop => prop.Id == 1);


            var musicoAlbumService = sp.GetService<IBaseService<MusicoAlbum>>();
            var musicoAlbum = new MusicoAlbum
            {
                Musico = musico,
                Album = album
            };

            var result = musicoAlbumService.Add<MusicoAlbum, MusicoAlbum, MusicoAlbumValidator>(musicoAlbum);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectMusicoAlbum() //lista os dados
        {
            var sp = ConfigureServices();
            var musicoAlbumService = sp.GetService<IBaseService<MusicoAlbum>>();

            var result = musicoAlbumService.Get<MusicoAlbum>();
            Console.Write(JsonSerializer.Serialize(result));
        }



    }
}
