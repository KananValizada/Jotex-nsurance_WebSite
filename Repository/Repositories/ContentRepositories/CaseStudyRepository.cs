using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface ICaseStudyRepository
    {
        IEnumerable<CaseStudy> GetCaseStudy();
        CaseStudy GetCaseStudyById(int Id);
    }
    public class CaseStudyRepository : ICaseStudyRepository
    {
        private readonly JotexDbContext _context;
        public CaseStudyRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<CaseStudy> GetCaseStudy()
        {
            return _context.CaseStudy.Include("StudySpecs").Where(c => c.Status).ToList();
        }

        public CaseStudy GetCaseStudyById(int Id)
        {
            return _context.CaseStudy.Include("StudySpecs").FirstOrDefault(s => s.Id == Id);
        }
    }
}
