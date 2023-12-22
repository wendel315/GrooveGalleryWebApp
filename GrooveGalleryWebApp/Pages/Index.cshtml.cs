using Microsoft.AspNetCore.Mvc.RazorPages;
using GrooveGalleryWebApp.Models;
using GrooveGalleryWebApp.Services;

namespace GrooveGalleryWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private IAlbumService _service;

        public IndexModel(IAlbumService albumService)
        {
            _service = albumService;
        }

        public IList<Album> ListaAlbum { get; private set; }

        public void OnGet()
        {
            ViewData["Title"] = "Home page";

            ListaAlbum = _service.ObterTodos();
        }
    }
}