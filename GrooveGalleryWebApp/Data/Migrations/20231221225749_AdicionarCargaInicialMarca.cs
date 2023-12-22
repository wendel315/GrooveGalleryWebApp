using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using GrooveGalleryWebApp.Data;
using GrooveGalleryWebApp.Models;

#nullable disable

namespace GrooveGalleryWebApp.Data.Migrations
{
    public partial class AdicionarCargaInicialMarca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var context = new GrooveGalleryDbContext();
                context.Marca.AddRange(ObterCargaInicial());
                context.SaveChanges();
            
        }

        private IList<Marca> ObterCargaInicial()
        {
            return new List<Marca>()
            {
                new Marca() { Descricao = "MK Music" },
                new Marca() { Descricao = "Sony Music" },
                new Marca() { Descricao = "Track Records" },
                new Marca() { Descricao = "Atlantic Records" },
                new Marca() { Descricao = "Capitol Records" },
                new Marca() { Descricao = "Universal Music Group" },
            };
        }
    }
}
