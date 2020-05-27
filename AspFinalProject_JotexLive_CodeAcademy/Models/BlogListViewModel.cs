using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinalProject_JotexLive_CodeAcademy.Models
{
    public class BlogListViewModel
    {
        
        public BlogViewModel Blog { get; set; }
        public int Count { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}
