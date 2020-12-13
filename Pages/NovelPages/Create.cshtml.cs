using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Novels.Data;
using Novels.Models;

namespace Novels.Pages.NovelPages
{
    public class CreateModel : PageModel
    {
        private readonly Novels.Data.NovelsContext _context;

        public CreateModel(Novels.Data.NovelsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GenreId"] = new SelectList(_context.Set<Genre>(), "GenreId", "GenreId");
            return Page();
        }

        [BindProperty]
        public Novel Novel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Novel.Add(Novel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
