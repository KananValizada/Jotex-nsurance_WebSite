using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class LikeableArea:BaseEntity
    {
        [Required]
        public int ExpYear { get; set; }
        [Required]
        [MaxLength(50)]
        public string Slogan { get; set; }
        [Required]
        [MaxLength(200)]
        public string Text { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }
        [Required]
        [MaxLength(100)]
        public string Photo { get; set; }

    }
}
