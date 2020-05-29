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

        public void DeleteServise(Service service)
        {
            _context.Services.Remove(service);
            _context.SaveChanges();
        }

        public IEnumerable<Service> getBestServices(int count)
        {
            return _context.Services.Include("Blogs")
                                    .Include("Agents")
                                    .Include("Agents.CaseStudies") 
                                    .Include("ServiceSpecs")
                                    .Include("ServiceFeatures")
                                    .Include("Blogs.BlogImages").Where(s => s.Status).Take(count).ToList();
        }

        public IEnumerable<Blog> GetBlogById(int Id)
        {
            return _context.Blogs
                            .Include("BlogComments")
                            .Include("BlogSlogans")
                            .Include("BlogImages").Where(b => b.Id == Id).Where(s => s.Status);
        }

        public Service getServiceById(int id)
        {
            return _context.Services.Find(id);
        }

        public IEnumerable<Service> getServices()
        {
            return _context.Services.ToList();
        }

        public void PostBlogComment(BlogComment comment)
        {

            _context.BlogComments.Add(comment);
            _context.SaveChanges();
        }

        public void UpdateServise(Service serviseToUpdate, Service model)
        {
            serviseToUpdate.Name = model.Name;
            serviseToUpdate.Text = model.Text;
            serviseToUpdate.Description = model.Description;
            serviseToUpdate.Slogan = model.Slogan;
            serviseToUpdate.Image = model.Image;
            serviseToUpdate.Logo = model.Logo;
            serviseToUpdate.ModifiedAt = model.ModifiedAt;
            serviseToUpdate.ModifiedBy = model.ModifiedBy;
            _context.SaveChanges();
        }

        Blog IBestServicesRepository.GetBlogById(int Id)
        {
            return _context.Blogs
                           .Include("BlogComments")
                           .Include("BlogSlogans")
                           .Include("BlogImages").FirstOrDefault(b=>b.Id==Id);
        }
    }
}
