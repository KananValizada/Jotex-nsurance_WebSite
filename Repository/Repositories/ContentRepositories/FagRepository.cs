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

        public IEnumerable<Fag> GetFags(int count)
        {
            return _context.Fags.Where(f => f.Status)
                                .Take(count)
                                .ToList();
        }
    }
}
