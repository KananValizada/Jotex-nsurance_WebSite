using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Blog
{
    public class BlogImageViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public int BlogId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        public BlogViewModel Blog { get; set; }
    }
}
