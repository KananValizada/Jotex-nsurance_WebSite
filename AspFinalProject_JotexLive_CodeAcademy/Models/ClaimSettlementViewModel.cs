using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinalProject_JotexLive_CodeAcademy.Models
{
    public class ClaimSettlementViewModel
    {

        public string Title { get; set; }
        public List<ClaimSettlementOptionViewModel>  claimSettlementOptions { get; set; }

    }
}
