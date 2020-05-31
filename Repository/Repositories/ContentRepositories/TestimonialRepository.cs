using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface ITestimonialRepository
    {
        IEnumerable<Testimonial> GetTestimonials();
        void CreateTestimonial(Testimonial model);
        Testimonial GetTestimonialById(int id);
        void UpdateTestimonial(Testimonial TestimonialToUpdate, Testimonial model);
        void DeleteTestimonial(Testimonial slg);
    }
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly JotexDbContext _context;
        public TestimonialRepository(JotexDbContext context)
        {
            _context = context;
        }

        public void CreateTestimonial(Testimonial model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Testimonials.Add(model);
            _context.SaveChanges();
        }

        public void DeleteTestimonial(Testimonial slg)
        {
            _context.Testimonials.Remove(slg);
            _context.SaveChanges();
        }

        public IEnumerable<Testimonial> GetTestimonials()
        {
            return _context.Testimonials.ToList();
        }

        public Testimonial GetTestimonialById(int id)
        {
            return _context.Testimonials.Find(id);
        }

        public void UpdateTestimonial(Testimonial blogTestimonialToUpdate, Testimonial model)
        {
            blogTestimonialToUpdate.Status = model.Status;
            blogTestimonialToUpdate.AboutUsId = model.AboutUsId;
            blogTestimonialToUpdate.ServiceId = model.ServiceId;
            blogTestimonialToUpdate.Review = model.Review;
            blogTestimonialToUpdate.UserName = model.UserName;
            blogTestimonialToUpdate.UserProfession = model.UserProfession;
            blogTestimonialToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }



    }
}
