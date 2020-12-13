using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Novels.Data;
using Novels.Models;

namespace Novels.Pages.NovelAuthorPages
{
    public class DetailsModel : PageModel
    {
        private readonly Novels.Data.NovelsContext _context;

        public DetailsModel(Novels.Data.NovelsContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
