using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class StudySpec : BaseEntity
    {
        public int CaseStudyId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public CaseStudy CaseStudy { get; set; }
    }
}
