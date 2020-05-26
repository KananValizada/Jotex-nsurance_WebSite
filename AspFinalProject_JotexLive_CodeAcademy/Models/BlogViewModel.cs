using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinalProject_JotexLive_CodeAcademy.Models
{
    public class BlogViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        public string Subtitle { get; set; }

        public string Subtext { get; set; }

        public string ActionText { get; set; }
        public List<BlogImageViewModel> BlogImages { get; set; }
        public List<BlogSloganViewModel> BlogSlogans { get; set; }
        public List<BlogComment> BlogComments { get; set; }


    }
}
