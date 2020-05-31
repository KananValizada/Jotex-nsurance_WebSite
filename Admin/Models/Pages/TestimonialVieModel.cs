using Admin.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Pages
{
    public class TestimonialVieModel
    {
        public int Id { get; set; }
        public int AboutUsId { get; set; }
        public int ServiceId { get; set; }
        public bool Status { get; set; }
        [Required]
        [MaxLength(500)]
        public string Review { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(50)]
        public string UserProfession { get; set; }
        public ServiceViewModel Service { get; set; }
        public AboutUsViewModel AboutUs { get; set; }
    }
}
