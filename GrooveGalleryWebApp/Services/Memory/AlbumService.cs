using GrooveGalleryWebApp.Models;


namespace GrooveGalleryWebApp.Services.Memory
{
    public class AlbumService : IAlbumService
    {
        private IList<Album> _albums;

        public AlbumService()
            => CarregarListaInicial();
        

        private void CarregarListaInicial()
        {
            _albums = new List<Album>()
            {
                new Album
                {
                    AlbumId = 1,
                    Nome = "Are you experienced",
                    Artista = "Artista 1",
                    Descricao = "Album do Jimi Hendrix que revolucionou a indústria do rock",
                    ImagemUri = "/images/jimi-hendrix.jpg",
                    Preco = 19.99,
                    EntregaExpressa = true,
                    Duracao = new TimeSpan(0, 45, 30),
                    DataLancamento = new DateTime(2022, 1, 15),
                    DataCadastro = DateTime.Now,
                },
                new Album
                {
                    AlbumId = 2,
                    Nome = "Álbum 2",
                    Artista = "Artista 2",
                    Descricao = "Descrição do Álbum 2",
                    ImagemUri = "/images/led-zeppelin.jpg",
                    Preco = 24.99,
                    EntregaExpressa = false,
                    Duracao = new TimeSpan(1, 10, 15),
                    DataLancamento = new DateTime(2022, 3, 20),
                    DataCadastro = DateTime.Now,
                    
                },
            };
        }

        public IList<Album> ObterTodos()
        {
            return _albums;
        }

        public Album Obter(int id)
        {
            return _albums.SingleOrDefault(item => item.AlbumId == id);
        }

        public void Incluir(Album album)
        {
            var proximoNumero = _albums.Max(item => item.AlbumId) + 1;
            album.AlbumId = proximoNumero;
            _albums.Add(album);
        }

        public void Alterar(Album album)
        {
            var albumEncontrado = Obter(album.AlbumId);
            albumEncontrado.Nome = album.Nome;
            albumEncontrado.Artista = album.Artista;
            albumEncontrado.Descricao = album.Descricao;
            albumEncontrado.ImagemUri = album.ImagemUri;
            albumEncontrado.Preco = album.Preco;
            albumEncontrado.EntregaExpressa = album.EntregaExpressa;
            albumEncontrado.Duracao = album.Duracao;
            albumEncontrado.DataLancamento = album.DataLancamento;
            albumEncontrado.DataCadastro = album.DataCadastro;
        }

        public void Excluir(int id)
        {
            var albumEncontrado = Obter(id);
            _albums.Remove(albumEncontrado);
        }

        public IList<Marca> ObterTodasAsMarcas()
        {
            return new List<Marca>()
            {
                new Marca() { MarcaId = 1, Descricao = "Som Livre" },
                new Marca() { MarcaId = 2, Descricao = "MK Records" },
            };
        }

    }
}
