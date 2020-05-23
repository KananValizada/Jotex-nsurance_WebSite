using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinalProject_JotexLive_CodeAcademy.Models
{
    public class BlogViewModel
    {

        public string Title { get; set; }

        public string Text { get; set; }

        public string Subtitle { get; set; }

        public string Subtext { get; set; }

        public string ActionText { get; set; }
        public List<BlogImageViewModel> BlogImages { get; set; }


    }
}
