using Admin.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Pages
{
    public class AboutUsViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public int SettingsId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }
        [Required]
        [MaxLength(100)]
        public string SubTitle { get; set; }

        [Required]
        [MaxLength(300)]
        public string About { get; set; }
        [Required]
        public decimal PolicyCount { get; set; }
        [Required]
        [MaxLength(100)]
        public string PolicyText { get; set; }
        public string PolicyActionText { get; set; }
        [Required]
        public decimal ClaimPercent { get; set; }
        [Required]
        [MaxLength(100)]
        public string ClaimText { get; set; }
        public string ClaimActionText { get; set; }
        [Required]
        public int OfficeCount { get; set; }
        [Required]
        [MaxLength(100)]
        public string OfficeText { get; set; }
        public string OfficeActionText { get; set; }
        public SettingsViewModel Settings { get; set; }
    }
}
