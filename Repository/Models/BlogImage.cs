using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class BlogImage : BaseEntity
    {
        [Required]
        public int BlogId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        public Blog Blog { get; set; }
    }
}
