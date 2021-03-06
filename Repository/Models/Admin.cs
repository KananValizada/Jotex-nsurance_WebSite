﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Admin : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Token { get; set; }
        [MaxLength(50)]
        public string ForgetToken { get; set; }
    }
}
