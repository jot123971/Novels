using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novels.Models
{
    public class Author
    {
        // constructor for author
        public Author()
        {
            NovelAuthors = new List<NovelAuthor>();

        }
        // seting pk for entity
        [Key]
        public int AuthorId { get; set; }
        // to store name of author
        public string Name { get; set; }
        // Author bio
        public string Bio { get; set; }
        // setting novel authors relationship
        public List<NovelAuthor> NovelAuthors { get; set; }
    }
}
