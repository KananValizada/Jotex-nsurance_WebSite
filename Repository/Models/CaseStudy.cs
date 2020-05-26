using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class CaseStudy : BaseEntity
    {
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
        public Agent Agent { get; set; }
        public ICollection<StudySpec> StudySpecs { get; set; }
    }
}
