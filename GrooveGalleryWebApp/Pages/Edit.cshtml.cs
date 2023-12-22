using GrooveGalleryWebApp.Models;
using GrooveGalleryWebApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System.Collections.Generic;
using System.Linq;

namespace GrooveGalleryWebApp.Pages
{
    [Authorize]
    public class EditModel : PageModel
    {

        private IToastNotification _toastNotification;
        private IAlbumService _service;
        public SelectList MarcaOptionItems { get; set; }

        public EditModel(IAlbumService albumService
            , IToastNotification toastNotification)
        {
            _service = albumService;
            _toastNotification = toastNotification;
        }

        

        [BindProperty]
        public Album Album { get; set; }
        public void OnGet(int id)
        {
            Album = _service.Obter(id);
            MarcaOptionItems = new SelectList(_service.ObterTodasAsMarcas(),
                                                nameof(Marca.MarcaId),
                                                nameof(Marca.Descricao));
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Alterar(Album);

            _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso!");

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostDelete()
        {
            _service.Excluir(Album.AlbumId);

            _toastNotification.AddSuccessToastMessage("Operação realizada com sucesso!");

            return RedirectToPage("/Index");
        }
    }
}
