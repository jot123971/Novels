using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Novels.Models
{
    public class Novel
    {
        // primary key for the novel entity
        [Key]
        public int NovelId { get; set; }

        // title of the novel
        public string Title { get; set; }

        // review date of the novel

        public DateTime Review { get; set; }

        // is novel famouus boolean property
        public bool IsFamous { get; set; }

        // some comments on novel

        public string Comments { get; set; }
       
        // setting foreign key
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public Genre Genres { get; set; }
        
        // list of foreign key authors relation
        public List<Author> Authors { get; set; }

        public Novel()
        {
            Authors = new List<Author>();
        }
    }
}
