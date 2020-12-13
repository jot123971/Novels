using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Novels.Data;
using Novels.Models;

namespace Novels.Pages.NovelPages
{
    public class EditModel : PageModel
    {
        private readonly Novels.Data.NovelsContext _context;

        public EditModel(Novels.Data.NovelsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Novel Novel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Novel = await _context.Novel
                .Include(n => n.Genres).FirstOrDefaultAsync(m => m.NovelId == id);

            if (Novel == null)
            {
                return NotFound();
            }
           ViewData["GenreId"] = new SelectList(_context.Set<Genre>(), "GenreId", "GenreId");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Novel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NovelExists(Novel.NovelId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool NovelExists(int id)
        {
            return _context.Novel.Any(e => e.NovelId == id);
        }
    }
}
