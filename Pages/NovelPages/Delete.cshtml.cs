using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Novels.Data;
using Novels.Models;

namespace Novels.Pages.NovelPages
{
    public class DeleteModel : PageModel
    {
        private readonly Novels.Data.NovelsContext _context;

        public DeleteModel(Novels.Data.NovelsContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Novel = await _context.Novel.FindAsync(id);

            if (Novel != null)
            {
                _context.Novel.Remove(Novel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
