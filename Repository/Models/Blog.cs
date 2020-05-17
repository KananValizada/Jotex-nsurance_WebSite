using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Blog :BaseEntity
    {
        [Required]
        public int ServiceId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        public Service Service { get; set; }
        public ICollection<BlogComment> BlogComments { get; set; }
        public ICollection<BlogSlogan> BlogSlogans { get; set; }
    }
}
