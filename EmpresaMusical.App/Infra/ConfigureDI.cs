using AutoMapper;
using EmpresaMusical.App.Cadastros;
using EmpresaMusical.App.Models;
using EmpresaMusical.App.Outros;
using EmpresaMusical.Domain.Base;
using EmpresaMusical.Domain.Entities;
using EmpresaMusical.Repository.Context;
using EmpresaMusical.Repository.Repository;
using EmpresaMusical.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaMusical.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region Banco de dados
            // Configura Banco na Injeção de dependencia
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Instrumento>, BaseRepository<Instrumento>>();
            Services.AddScoped<IBaseRepository<Musico>, BaseRepository<Musico>>();
            Services.AddScoped<IBaseRepository<Album>, BaseRepository<Album>>();
            Services.AddScoped<IBaseRepository<Musica>, BaseRepository<Musica>>();
            Services.AddScoped<IBaseRepository<MusicoAlbum>, BaseRepository<MusicoAlbum>>();
            Services.AddScoped<IBaseRepository<MusicoInstrumento>, BaseRepository<MusicoInstrumento>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Instrumento>, BaseService<Instrumento>>();
            Services.AddScoped<IBaseService<Musico>, BaseService<Musico>>();
            Services.AddScoped<IBaseService<Album>, BaseService<Album>>();
            Services.AddScoped<IBaseService<Musica>, BaseService<Musica>>();
            Services.AddScoped<IBaseService<MusicoAlbum>, BaseService<MusicoAlbum>>();
            Services.AddScoped<IBaseService<MusicoInstrumento>, BaseService<MusicoInstrumento>>();
            #endregion

            #region Formulários
            // Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroInstrumento, CadastroInstrumento>();
            Services.AddTransient<CadastroMusico, CadastroMusico>();
            Services.AddTransient<CadastroAlbum, CadastroAlbum>();
            Services.AddTransient<CadastroMusica, CadastroMusica>();
            Services.AddTransient<CadastroMusicoInstrumento, CadastroMusicoInstrumento>();
            Services.AddTransient<CadastroMusicoAlbum, CadastroMusicoAlbum>();
            #endregion

            #region Mappings
            // Mappings

            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Instrumento, InstrumentoModels>()
                    .ForMember(d => d.NomeInstrumento, d => d.MapFrom(prop => $"{prop.NomeInstrumento}/{prop.Tipo}"));
                    //.ForMember(d => d.NomeInstrumento, d => d.MapFrom(prop => $"{prop.NomeInstrumento}/{prop.Tipo}"));

                config.CreateMap<Musico, MusicoModel>()
                    .ForMember(d => d.NomeMusico, d => d.MapFrom(x => $"{x.NomeMusico}"));

                config.CreateMap<MusicoInstrumento, MusicoInstrumentoModel>()
                    .ForMember(d => d.IdMusico, d => d.MapFrom(x => $"{x.Musico!.Id}"))
                    .ForMember(d => d.Musico, d => d.MapFrom(x => $"{x.Musico!.NomeMusico}"))
                    .ForMember(d => d.IdInstrumento, d => d.MapFrom(x => $"{x.Instrumento!.Id}"))
                    .ForMember(d => d.Instrumento, d => d.MapFrom(x => $"{x.Instrumento!.NomeInstrumento}"));

                config.CreateMap<Album, AlbumModel>()
                    .ForMember(d => d.TituloAlbum, d => d.MapFrom(x => $"{x.TituloAlbum!}"))
                    .ForMember(d => d.Data, d => d.MapFrom(x => $"{x.Data!}"));

                config.CreateMap<Musica, MusicaModel>()
                    .ForMember(d => d.Album, d => d.MapFrom(x => x.Album!.TituloAlbum))
                    .ForMember(d => d.IdAlbum, d => d.MapFrom(x => x.Album!.Id));

                config.CreateMap<MusicoAlbum, MusicoAlbumModel>()
                    .ForMember(d => d.IdMusico, d => d.MapFrom(x => $"{x.Musico!.Id}"))
                    .ForMember(d => d.Musico, d => d.MapFrom(x => $"{x.Musico!.NomeMusico}"))
                    .ForMember(d => d.IdAlbum, d => d.MapFrom(x => $"{x.Album!.Id}"))
                    .ForMember(d => d.Album, d => d.MapFrom(x => $"{x.Album!.TituloAlbum}"));

            }).CreateMapper());

            #endregion
            ServicesProvider = Services.BuildServiceProvider();
            }
        }
    }
