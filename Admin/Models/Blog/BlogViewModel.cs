using Admin.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Blog
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public int ServiceId { get; set; }
        [Required(ErrorMessage ="Başlıq məcburidir")]
        [MaxLength(50,ErrorMessage ="Başlıq max 50 xarakter ola bilər")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Mətn məcburidir")]
        [MaxLength(500, ErrorMessage = "Mətn max 500 xarakter ola bilər")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Digər Başlıq məcburidir")]
        [MaxLength(50, ErrorMessage = "Digər Başlıq max 50 xarakter ola bilər")]
        public string Subtitle { get; set; }
        [Required(ErrorMessage = "Digər mətn məcburidir")]
        [MaxLength(500, ErrorMessage = "Digər mətn max 500 xarakter ola bilər")]
        public string Subtext { get; set; }
        [Required(ErrorMessage = "Button mətni məcburidir")]
        [MaxLength(50, ErrorMessage = "Button mətni max 50 xarakter ola bilər")]
        public string ActionText { get; set; }
        public ServiceViewModel Service { get; set; }
    }
}
