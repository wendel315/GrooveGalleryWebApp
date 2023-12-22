using GrooveGalleryWebApp.Models;
using GrooveGalleryWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System.Collections.Generic;
using System.Linq;

namespace GrooveGalleryWebApp.Pages
{
    public class EditModel : PageModel
    {
        private IAlbumService _service;

        public EditModel(IAlbumService albumService)
        {
            _service = albumService;
        }

        public void OnGet(int id)
        {
            Album = _service.Obter(id);
        }
        

        [BindProperty]
        public Album Album { get; set; }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Alterar(Album);


            return RedirectToPage("/Index");
        }

        public IActionResult OnPostDelete()
        {
            _service.Excluir(Album.AlbumId);

            TempData["TempMensagemSucesso"] = true;

            return RedirectToPage("/Index");
        }
    }
}
