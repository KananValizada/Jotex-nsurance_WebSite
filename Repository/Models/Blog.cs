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
        [Required]
        [MaxLength(50)]
        public string Subtitle { get; set; }
        [Required]
        [MaxLength(500)]
        public string Subtext { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        public Service Service { get; set; }
        public ICollection<BlogComment> BlogComments { get; set; }
        public ICollection<BlogSlogan> BlogSlogans { get; set; }
        public ICollection<BlogImage> BlogImages { get; set; }
    }
}
