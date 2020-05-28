using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public class FagRepository : IFagRepository
    {
        private readonly JotexDbContext _context;
        public FagRepository(JotexDbContext context)
        {
            _context = context;
        }

        public Fag CreateFag(Fag model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Fags.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void DeleteFag(Fag fag)
        {
            _context.Fags.Remove(fag);
            _context.SaveChanges();
        }

        public IEnumerable<Fag> GetAllFags()
        {
            return _context.Fags.ToList();
        }

        public Fag GetFagById(int id)
        {
            return _context.Fags.Find(id);
        }

        public IEnumerable<Fag> GetFags()
        {
            return _context.Fags.Where(f => f.Status)
                                .ToList();
        }

        public void UpdateFag(Fag fagToUpdate, Fag model)
        {
            fagToUpdate.Status = model.Status;
            fagToUpdate.Question = model.Question;
            fagToUpdate.Answer = model.Answer;
            fagToUpdate.ModifiedBy = model.ModifiedBy;
            fagToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }
    }
}
