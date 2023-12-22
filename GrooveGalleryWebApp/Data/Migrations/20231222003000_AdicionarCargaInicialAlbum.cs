using GrooveGalleryWebApp.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GrooveGalleryWebApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarCargaInicialAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var context = new GrooveGalleryDbContext();
            context.Album.AddRange(ObterCargaInicial());
            context.SaveChanges();

        }

        private IList<Album> ObterCargaInicial()
        {
            return new List<Album>()
            {
               new Album
                {
                    Nome = "Abbey Road",
                    Artista = "The Beatles",
                    Descricao = "A jornada sonora que atravessa gerações.",
                    ImagemUri = "/images/abbey-road.jpg",
                    Preco = 29.99,
                    EntregaExpressa = true,
                    Duracao = new TimeSpan(0, 47, 15),
                    DataLancamento = new DateTime(1969, 9, 26),
                    DataCadastro = DateTime.Now
                },
                new Album
                {
                    Nome = "The Dark Side of the Moon",
                    Artista = "Pink Floyd",
                    Descricao = "Uma viagem cósmica através do som e da mente.",
                    ImagemUri = "/images/dark-side-of-the-moon.jpg",
                    Preco = 34.99,
                    EntregaExpressa = true,
                    Duracao = new TimeSpan(0, 42, 57),
                    DataLancamento = new DateTime(1973, 3, 1),
                    DataCadastro = DateTime.Now
                },
                new Album
                {
                    Nome = "Thriller",
                    Artista = "Michael Jackson",
                    Descricao = "O álbum que fez história e mudou o pop para sempre.",
                    ImagemUri = "/images/thriller.jpg",
                    Preco = 39.99,
                    EntregaExpressa = false,
                    Duracao = new TimeSpan(0, 42, 19),
                    DataLancamento = new DateTime(1982, 11, 30),
                    DataCadastro = DateTime.Now
                }

            };
        }
    }
}
