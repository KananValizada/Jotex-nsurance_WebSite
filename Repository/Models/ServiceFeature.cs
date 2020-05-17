using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ServiceFeature :BaseEntity
    {
        [Required]
        public int ServiceId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public string Logo { get; set; }
        public Service Service { get; set; }
    }
}
