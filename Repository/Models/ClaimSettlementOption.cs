using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ClaimSettlementOption : BaseEntity
    {
        public int ClaimSettlementId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Subtitle { get; set; }
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }
        public ClaimSettlement ClaimSettlement { get; set; }
    }
}
