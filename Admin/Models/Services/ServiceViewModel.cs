using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Services
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage ="Xidmət adı vacibdir")]
        [MaxLength(50, ErrorMessage = "Xidmət adı max 50 xarakter ola bilər")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Xidmət Logosu vacibdir")]
        [MaxLength(100, ErrorMessage = "Xidmət logosu max 100 xarakter ola bilər")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "Xidmət mətni vacibdir")]
        [MaxLength(500, ErrorMessage = "Xidmət mətni max 500 xarakter ola bilər")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Xidmət Sloqanı vacibdir")]
        [MaxLength(100, ErrorMessage = "Xidmət sloqanı max 500 xarakter ola bilər")]
        public string Slogan { get; set; }
        [Required(ErrorMessage = "Xidmət Açıqlaması vacibdir")]
        [MaxLength(250, ErrorMessage = "Xidmət açıqlaması max 250 xarakter ola bilər")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Xidmət Şəkli vacibdir")]
        [MaxLength(100)]
        public string Image { get; set; }
    }
}
