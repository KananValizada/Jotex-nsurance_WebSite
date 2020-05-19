using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class ClaimSettlement :BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public IEnumerable<ClaimSettlementOption> ClaimSettlementOptions { get; set; }

    }
}
