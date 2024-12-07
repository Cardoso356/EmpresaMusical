using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaMusical.Domain.Entities;
using System.Diagnostics;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.Metrics;

namespace EmpresaMusical.Test
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestInstrumento()
        {
            Instrumento instrumento = new Instrumento(1,"Piano", "percussão");

            Debug.WriteLine(JsonSerializer.Serialize(instrumento));

            Assert.AreEqual(instrumento.NomeInstrumento, "Piano");
            Assert.AreEqual(instrumento.Tipo, "percussão");
        }

        [TestMethod]
        public void TestMusico()
        {
            Musico musico = new Musico(1, "Beethoven", "Viena", "OMaisFoda@gmail.com", "991014375");

            Debug.WriteLine(JsonSerializer.Serialize(musico));

            Assert.AreEqual(musico.NomeMusico, "Beethoven");
            Assert.AreEqual(musico.Endereco, "Viena");
            Assert.AreEqual(musico.Email, "OMaisFoda@gmail.com");
            Assert.AreEqual(musico.Telefone, "991014375");
        }

        [TestMethod]
        public void TestAlbum()
        {
            Album album = new Album(1, "Sonata ao Luar", "vinil", DateTime.Parse("2002-05-22"));
            //é necessário esse datetime.parse() para poder configurar um valor de data

            Debug.WriteLine(JsonSerializer.Serialize(album));

            Assert.AreEqual(album.TituloAlbum, "Sonata ao Luar");
            Assert.AreEqual(album.Formato, "vinil");
            Assert.AreEqual(album.Data, DateTime.Parse("2002-05-22"));
        }

        [TestMethod]
        public void TestMusica()
        {
            Album album = new Album(1, "Sonata ao Luar", "vinil", DateTime.Parse("2002-05-22"));
            Musica musica = new Musica(1, "Fur Elise", "vienaMusicals", album);

            Assert.AreEqual(musica.NomeMusica, "Fur Elise");
            Assert.AreEqual(musica.Gravadora, "vienaMusicals");
            Assert.AreEqual(musica.Album, album);
        }

        [TestMethod]
        public void TestMusicoInstrumento()
        {
            Musico musico = new Musico(1, "Beethoven", "Viena", "OMaisFoda@gmail.com", "991014375");
            Instrumento instrumento = new Instrumento(1, "Piano", "percussão");

            MusicoInstrumento musicoInstrumento = new MusicoInstrumento(musico, instrumento);

            Assert.AreEqual(musicoInstrumento.Musico, musico);
            Assert.AreEqual(musicoInstrumento.Instrumento, instrumento);           
        }

        [TestMethod]
        public void TestMusicoAlbum()
        {
            Musico musico = new Musico(1, "Beethoven", "Viena", "OMaisFoda@gmail.com", "991014375");
            Album album = new Album(1, "Sonata ao Luar", "vinil", DateTime.Parse("2002-05-22"));

            MusicoAlbum musicoAlbum = new MusicoAlbum(musico, album);

            Assert.AreEqual(musicoAlbum.Musico, musico);
            Assert.AreEqual(musicoAlbum.Album, album);
        }

    }
}
