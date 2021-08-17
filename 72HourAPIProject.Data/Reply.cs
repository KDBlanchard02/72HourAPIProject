﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72HourAPIProject.Data
{
    public class Reply
    {
        [Key]
        public int ReplyId { get; set; }

        [ForeignKey(nameof(Comment))]
        public int CommentId { get; set; }

        [Required]
        public Guid AuthorId { get; set; }
        [Required]
        public string Text { get; set; }

        public virtual Comment comment { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTimeOffset CreatedUtc { get; set; }

    }
}
