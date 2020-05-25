using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public class BestServicesRepository : IBestServicesRepository
    {
        private readonly JotexDbContext _context;
        public BestServicesRepository(JotexDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Service> getBestServices(int count)
        {
            return _context.Services.Include("Blogs")
                                    .Include("Agents")
                                    .Include("ServiceSpecs")
                                    .Include("ServiceFeatures")
                                    .Include("Blogs.BlogImages").Where(s => s.Status).Take(count).ToList();
        }
    }
}
