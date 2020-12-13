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

namespace Novels.Pages.NovelAuthorPages
{
    public class EditModel : PageModel
    {
        private readonly Novels.Data.NovelsContext _context;

        public EditModel(Novels.Data.NovelsContext context)
        {
            _context = context;
        }

        [BindProperty]
        public NovelAuthor NovelAuthor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            NovelAuthor = await _context.NovelAuthor
                .Include(n => n.Authors)
                .Include(n => n.Novels).FirstOrDefaultAsync(m => m.NovelAuthorId == id);

            if (NovelAuthor == null)
            {
                return NotFound();
            }
           ViewData["AuthorId"] = new SelectList(_context.Author, "AuthorId", "AuthorId");
           ViewData["NovelId"] = new SelectList(_context.Novel, "NovelId", "NovelId");
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

            _context.Attach(NovelAuthor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NovelAuthorExists(NovelAuthor.NovelAuthorId))
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

        private bool NovelAuthorExists(int id)
        {
            return _context.NovelAuthor.Any(e => e.NovelAuthorId == id);
        }
    }
}
