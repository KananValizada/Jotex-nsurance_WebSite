using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinalProject_JotexLive_CodeAcademy.Models
{
    public class CaseStudyViewModel
    {
        public int Id { get; set; }
        public string MainTitle { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }
        public string Image { get; set; }

        public string ChallengeText { get; set; }

        public string SolutionText { get; set; }

        public string ResultText { get; set; }
        public List<StudySpec> studySpecs { get; set; }
    }
}
