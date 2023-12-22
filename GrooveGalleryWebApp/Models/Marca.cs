namespace GrooveGalleryWebApp.Models
{
    public class Marca
    {
        public int MarcaId { get; set; }
        public string Descricao { get; set; }

        public ICollection<Album> Albums { get; set; }

    }
}
