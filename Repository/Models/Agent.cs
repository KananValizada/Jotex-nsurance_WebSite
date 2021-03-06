﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Agent : BaseEntity
    {

        [Required]
        public int ServiceId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Profession { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        public Service Service { get; set; }
        public IEnumerable<CaseStudy> CaseStudies { get; set; }

    }
}
