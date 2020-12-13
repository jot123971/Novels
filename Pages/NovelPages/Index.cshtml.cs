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
    public class IndexModel : PageModel
    {
        private readonly Novels.Data.NovelsContext _context;

        public IndexModel(Novels.Data.NovelsContext context)
        {
            _context = context;
        }

        public IList<Novel> Novel { get;set; }

        public async Task OnGetAsync()
        {
            Novel = await _context.Novel
                .Include(n => n.Genres).ToListAsync();
        }
    }
}
