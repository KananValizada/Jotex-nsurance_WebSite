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
        IEnumerable<CaseStudy> GetAllCaseStudies();
        void CreateCaseStudy(CaseStudy model);
        void DeleteCaseStudy(CaseStudy model);
        void UpdateCaseStudy(CaseStudy modelToUpdate, CaseStudy model);

        CaseStudy GetCaseStudyById(int Id);
    }
    public class CaseStudyRepository : ICaseStudyRepository
    {
        private readonly JotexDbContext _context;
        public CaseStudyRepository(JotexDbContext context)
        {
            _context = context;
        }

        public void CreateCaseStudy(CaseStudy model)
        {
            model.CreatedAt = DateTime.Now;
            _context.CaseStudy.Add(model);
            _context.SaveChanges();
        }

        public void DeleteCaseStudy(CaseStudy model)
        {
            _context.CaseStudy.Remove(model);
            _context.SaveChanges();
        }

        public IEnumerable<CaseStudy> GetAllCaseStudies()
        {
            return _context.CaseStudy.ToList();
        }

        public IEnumerable<CaseStudy> GetCaseStudy()
        {
            return _context.CaseStudy.Include("StudySpecs").Where(c => c.Status).ToList();
        }

        public CaseStudy GetCaseStudyById(int Id)
        {
            return _context.CaseStudy.Include("StudySpecs").FirstOrDefault(s => s.Id == Id);
        }

        public void UpdateCaseStudy(CaseStudy modelToUpdate, CaseStudy model)
        {
            modelToUpdate.Status = model.Status;
            modelToUpdate.SolutionText = model.SolutionText;
            modelToUpdate.ResultText = model.ResultText;
            modelToUpdate.MainTitle = model.MainTitle;
            modelToUpdate.Image = model.Image;
            modelToUpdate.Text = model.Text;
            modelToUpdate.Title = model.Title;
            modelToUpdate.AgentId = model.AgentId;
            _context.SaveChanges();
        }
    }
}
