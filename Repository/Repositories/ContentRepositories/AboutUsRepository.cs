using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public class AboutUsRepository : IAboutUsRepository
    {
        private readonly JotexDbContext _context;
        public AboutUsRepository(JotexDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AboutUs> GetAboutUs()
        {
            return _context.AboutUs.Where(a => a.Status)
                                  .Include("Settings")
                                  .ToList();
        }

        public Settings GetSettings()
        {
            return _context.Settings.FirstOrDefault(s => s.Status);
        }
    }
}
