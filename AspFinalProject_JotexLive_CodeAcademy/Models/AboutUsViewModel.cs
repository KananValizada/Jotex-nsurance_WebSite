using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinalProject_JotexLive_CodeAcademy.Models
{
    public class AboutUsViewModel
    {
        public int SettingsId { get; set; }

        public string Title { get; set; }
 
        public string Text { get; set; }

        public string SubTitle { get; set; }

        public string About { get; set; }

        public decimal PolicyCount { get; set; }

        public string PolicyText { get; set; }

        public string PolicyActionText { get; set; }

        public decimal ClaimPercent { get; set; }

        public string ClaimText { get; set; }

        public string ClaimActionText { get; set; }

        public int OfficeCount { get; set; }

        public string OfficeText { get; set; }

        public string OfficeActionText { get; set; }
        public SettingsViewModel Settings { get; set; }

    }
}
