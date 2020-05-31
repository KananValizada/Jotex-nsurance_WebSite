using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinalProject_JotexLive_CodeAcademy.Models
{
    public class AgentViewModel
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string Profession { get; set; }

        public string Image { get; set; }
        public List<CaseStudyViewModel> CaseStudies { get; set; }
    }
}
