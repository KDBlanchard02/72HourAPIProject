using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourAPIProject.Models
{
    public class PostCreate
    {
        [Required]
        [MinLength(1, ErrorMessage = "Please enter at least 1 or more characters.")]
        [MaxLength(199, ErrorMessage = "There must be less than 200 characters.")]
        public string Title { get; set; }

        [MaxLength(8000)]
        public string Content { get; set; }

        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Category Name")]
        public int PostID { get; set; }
        public string UserName { get; set; }
    }
}
