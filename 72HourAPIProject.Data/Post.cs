using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _72HourAPIProject.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public Guid AuthorId { get; set; }

        [Required]
        public string Content { get; set; }
        
        [Required]
        public virtual List<Comment> Comments { get; set; }

        //[ForeignKey]
        // (nameof(Like))]
        //public virtual List<Like>

        [Required]
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Date Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }

    }
}

