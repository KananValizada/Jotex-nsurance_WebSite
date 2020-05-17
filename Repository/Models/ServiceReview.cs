﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ServiceReview :BaseEntity
    {
        [Required]
        public int ServiceId { get; set; }
        [Required]
        [MaxLength(500)]
        public string Review { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserProfession { get; set; }
        public Service Service { get; set; }
    }
}
