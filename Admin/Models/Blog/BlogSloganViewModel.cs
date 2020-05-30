using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Blog
{
    public class BlogSloganViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public int BlogId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public BlogViewModel Blog { get; set; }
    }
}
