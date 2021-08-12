using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourAPIProject.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public Guid AuthorId { get; set; }
        
        //public virtual List<Reply> Replies { get; set; }

        [Required]
        [ForeignKey("Post")]
        public virtual Post Post { get; set; }


        [Required]
        [Display(Name ="Created")]
        public DateTimeOffset CreatedUtc { get; set; }


        [Display(Name ="Modified")]
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
