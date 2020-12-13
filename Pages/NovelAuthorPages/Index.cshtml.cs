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
    public class IndexModel : PageModel
    {
        private readonly Novels.Data.NovelsContext _context;

        public IndexModel(Novels.Data.NovelsContext context)
        {
            _context = context;
        }

        public IList<NovelAuthor> NovelAuthor { get;set; }

        public async Task OnGetAsync()
        {
            NovelAuthor = await _context.NovelAuthor
                .Include(n => n.Authors)
                .Include(n => n.Novels).ToListAsync();
        }
    }
}
