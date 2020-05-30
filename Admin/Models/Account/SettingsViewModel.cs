using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Account
{
    public class SettingsViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        [Required(ErrorMessage ="Logo Vacibdir")]
        public string Logo { get; set; }
        [Required(ErrorMessage = "Sorğu üçün nömrə Vacibdir")]
        [MaxLength(50,ErrorMessage ="Sorğu nömrəsi maks 50 xarakter ola bilər")]

        public string QueryNumber { get; set; }
        [Required(ErrorMessage = "Ünvan Vacibdir")]
        [MaxLength(100, ErrorMessage = "Ünvan maks 100 xarakter ola bilər")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Telefon nömrəsi Vacibdir")]
        [MaxLength(50, ErrorMessage = "Telefon nömrəsi nömrəsi maks 50 xarakter ola bilər")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "E-Poçt Vacibdir")]
        [MaxLength(50, ErrorMessage = "E-poşt maks 50 xarakter ola bilər")]
        public string Email { get; set; }
        [Required(ErrorMessage = "İş saatları Vacibdir")]
        [MaxLength(50, ErrorMessage = "İş saatları maks 50 xarakter ola bilər")]
        public string WorkTime { get; set; }
    }
}
