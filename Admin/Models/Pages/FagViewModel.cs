using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Pages
{
    public class FagViewModel
    {
        public int Id { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required(ErrorMessage ="Sual vacibdir")]
        [MaxLength(500,ErrorMessage ="Sual 500 xarakterdən çox ola bilməz")]
        public string Question { get; set; }
        [Required(ErrorMessage ="Cavab yazmaq vacibdir")]
        [MaxLength(500,ErrorMessage ="Cavab 500 xarakterdən çox ola bilməz")]
        public string Answer { get; set; }
    }
}
