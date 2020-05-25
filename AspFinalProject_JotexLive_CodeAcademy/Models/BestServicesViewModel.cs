using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinalProject_JotexLive_CodeAcademy.Models
{
    public class BestServicesViewModel
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Text { get; set; }
        public string Slogan { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string EndPoint { get; set; }
        public List<BlogViewModel> Blogs { get; set; }
        public List<AgentViewModel> Agents { get; set; }
        public List<ServiceSpecViewModel> ServiceSpecs { get; set; }
        public List<ServiceFeatureViewModel> ServiceFeatures { get; set; }

    }
}
