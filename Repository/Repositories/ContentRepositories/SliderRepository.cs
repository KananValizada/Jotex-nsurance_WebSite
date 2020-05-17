using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public class SliderRepository : ISliderRepository
    {
        private readonly JotexDbContext _context;
        public SliderRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                       .OrderBy(s=>s.OrderBy)
                                       .ToList();
        }
    }
}
