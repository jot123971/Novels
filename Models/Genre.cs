using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Novels.Models
{
    public class Genre
    {
        // constructor for class Genre
        public Genre()
        {
            Novels = new List<Novel>();
        }
       
        // setting pk for entity 
        [Key]
        public int GenreId { get; set; }
        // name of genre
        public string GenreOfNovel { get; set; }
        
        // property used for foreign relationship with Novel
        public List<Novel> Novels { get; set; }
    }
}
