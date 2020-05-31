using Admin.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Pages
{
    public class CaseStudyViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public int AgentId { get; set; }
        [Required]
        [MaxLength(50)]
        public string MainTitle { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(500)]
        public string Text { get; set; }
        [Required]
        [MaxLength(500)]
        public string ChallengeText { get; set; }
        [Required]
        [MaxLength(500)]
        public string SolutionText { get; set; }
        [Required]
        [MaxLength(500)]
        public string ResultText { get; set; }
        public AgentViewModel Agent { get; set; }
    }
}
