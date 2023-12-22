using GrooveGalleryWebApp.Models;
using GrooveGalleryWebApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace GrooveGalleryWebApp.Pages
{
   
    public class CreateModel : PageModel
    {
        private IAlbumService _service;
        public SelectList MarcaOptionItems { get; set; }

        public CreateModel(IAlbumService albumService)
        {
            _service = albumService;
        }

        public void OnGet()
        {
            MarcaOptionItems = new SelectList(_service.ObterTodasAsMarcas(),
                                                nameof(Marca.MarcaId),
                                                nameof(Marca.Descricao));

        }



        [BindProperty]
        public Album Album { get; set; }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Incluir(Album);

            return RedirectToPage("/Index");
        }
    }
}
