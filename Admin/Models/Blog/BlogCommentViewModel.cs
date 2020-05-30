using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Blog
{
    public class BlogCommentViewModel
    {
        public int Id { get; set; }
        public bool  Status { get; set; }
        public int BlogId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        public BlogViewModel Blog { get; set; }
    }
}
