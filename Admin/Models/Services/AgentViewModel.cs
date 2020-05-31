using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Services
{
    public class AgentViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
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
        public ServiceViewModel Service { get; set; }
    }
}
