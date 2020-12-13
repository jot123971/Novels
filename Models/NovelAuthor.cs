using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Novels.Models
{
    public class NovelAuthor
    {
        // identity field
        [Key]
        public int NovelAuthorId { get; set; }
        // Foreign key for Authors table
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Authors { get; set; }
        // foreign key for Books table
        [ForeignKey("Novel")]
        public int NovelId { get; set; }
        public Novel Novels { get; set; }
    }
}
