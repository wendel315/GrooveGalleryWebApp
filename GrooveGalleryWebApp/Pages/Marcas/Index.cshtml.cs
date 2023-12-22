using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GrooveGalleryWebApp.Data;
using GrooveGalleryWebApp.Models;

namespace GrooveGalleryWebApp.Pages.Marcas
{
    public class IndexModel : PageModel
    {
        private readonly GrooveGalleryWebApp.Data.GrooveGalleryDbContext _context;

        public IndexModel(GrooveGalleryWebApp.Data.GrooveGalleryDbContext context)
        {
            _context = context;
        }

        public IList<Marca> Marca { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Marca != null)
            {
                Marca = await _context.Marca.ToListAsync();
            }
        }
    }
}
