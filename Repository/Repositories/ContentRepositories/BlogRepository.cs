using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> GetBlogs();
        void CreateBlog(Blog model);
        Blog GetBlogById(int id);
        void UpdateFag(Blog blogToUpdate, Blog model);
        void DeleteBlog(Blog blog);
    }
    public class BlogRepository : IBlogRepository
    {
        private readonly JotexDbContext _context;
        public BlogRepository(JotexDbContext context)
        {
            _context = context;
        }

        public void CreateBlog(Blog model)
        {
            model.CreatedAt = DateTime.Now;
            _context.Blogs.Add(model);
            _context.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
        }

        public Blog GetBlogById(int id)
        {
            return _context.Blogs.Find(id);
        }

        public IEnumerable<Blog> GetBlogs()
        {
            return _context.Blogs.ToList();
        }

        public void UpdateFag(Blog blogToUpdate, Blog model)
        {
            blogToUpdate.ModifiedAt = DateTime.Now;
            blogToUpdate.ServiceId = model.ServiceId;
            blogToUpdate.Status = model.Status;
            blogToUpdate.Text = model.Text;
            blogToUpdate.Title = model.Title;
            blogToUpdate.Subtext = model.Subtext;
            blogToUpdate.Subtitle = model.Subtitle;
            blogToUpdate.ActionText = model.ActionText;
            _context.SaveChanges();
        }
    }
}
