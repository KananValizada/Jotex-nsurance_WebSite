using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Service : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public string Slogan { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }
        public ICollection<ServiceSpec> ServiceSpecs { get; set; }
        public ICollection<ServiceFeature> ServiceFeatures { get; set; }
        public ICollection<ServiceReview> ServiceReviews { get; set; }
        public ICollection<Blog> Blogs { get; set; }


    }
}
