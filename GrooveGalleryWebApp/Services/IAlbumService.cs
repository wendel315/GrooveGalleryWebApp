using GrooveGalleryWebApp.Models;


namespace GrooveGalleryWebApp.Services
{
    public interface IAlbumService
    {
        IList<Album> ObterTodos();
        Album Obter(int id);
        void Incluir(Album album);
        void Alterar(Album album);
        void Excluir(int id);
        IList<Marca> ObterTodasAsMarcas();
    }
}
