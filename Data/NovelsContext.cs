using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Novels.Models;

namespace Novels.Data
{
    public class NovelsContext : DbContext
    {
        public NovelsContext (DbContextOptions<NovelsContext> options)
            : base(options)
        {
        }

        public DbSet<Novels.Models.Author> Author { get; set; }

        public DbSet<Novels.Models.Novel> Novel { get; set; }

        public DbSet<Novels.Models.NovelAuthor> NovelAuthor { get; set; }

        public DbSet<Novels.Models.Genre> Genre { get; set; }
    }
}
