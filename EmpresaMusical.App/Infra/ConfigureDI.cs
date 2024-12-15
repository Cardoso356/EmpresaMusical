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
            #endregion

            #region Mappings
            // Mappings

            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Instrumento, InstrumentoModels>()
                    .ForMember(d => d.NomeInstrumento, d => d.MapFrom(prop => $"{prop.NomeInstrumento}/{prop.Tipo}"));

                /*config.CreateMap<Cidade, CidadeModel>()
                    .ForMember(d => d.NomeEstado, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));
                config.CreateMap<Cliente, ClienteModel>()
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<Grupo, GrupoModel>();
                config.CreateMap<Produto, ProdutoModel>()
                    .ForMember(d => d.Grupo, d => d.MapFrom(x => x.Grupo!.Nome))
                    .ForMember(d => d.IdGrupo, d => d.MapFrom(x => x.Grupo!.Id));
                config.CreateMap<Venda, VendaModel>()
                    .ForMember(d => d.IdCliente, d => d.MapFrom(x => x.Cliente!.Id))
                    .ForMember(d => d.Cliente, d => d.MapFrom(x => x.Cliente!.Nome))
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));

                config.CreateMap<VendaItem, VendaItemModel>()
                    .ForMember(d => d.IdProduto, d => d.MapFrom(x => x.Produto!.Id))
                    .ForMember(d => d.Produto, d => d.MapFrom(x => x.Produto!.Nome));*/

            }).CreateMapper());

            #endregion
            ServicesProvider = Services.BuildServiceProvider();
            }
        }
    }
