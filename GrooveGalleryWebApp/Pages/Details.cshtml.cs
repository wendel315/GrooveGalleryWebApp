using GrooveGalleryWebApp.Models;
using GrooveGalleryWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GrooveGalleryWebApp.Pages;

public class DetailsModel : PageModel
{
    private IAlbumService _service;

    public DetailsModel(IAlbumService albumService)
    {
        _service = albumService;
    }

    public Album Album { get; private set; }
    public Marca Marca { get; private set; }

    public IActionResult OnGet(int id)
    {
        Album = _service.Obter(id);
        Marca = _service.ObterTodasAsMarcas().SingleOrDefault(item => item.MarcaId == Album.MarcaId);

        if (Album == null)
        {
            return NotFound();
        }

        return Page();
    }
}

