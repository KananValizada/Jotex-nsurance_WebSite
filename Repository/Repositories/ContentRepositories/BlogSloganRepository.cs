using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IBlogSloganRepository
    {
        IEnumerable<BlogSlogan> GetSlogans();
        void CreateSlogan(BlogSlogan model);
        BlogSlogan GetSloganById(int id);
        void UpdateSlogan(BlogSlogan blogSloganToUpdate, BlogSlogan model);
        void DeleteSlogan(BlogSlogan slg);
    }
    public class BlogSloganRepository : IBlogSloganRepository
    {
        private readonly JotexDbContext _context;
        public BlogSloganRepository(JotexDbContext context)
        {
            _context = context;
        }

        public void CreateSlogan(BlogSlogan model)
        {
            model.CreatedAt = DateTime.Now;
            _context.BlogSlogans.Add(model);
            _context.SaveChanges();
        }

        public void DeleteSlogan(BlogSlogan slg)
        {
            _context.BlogSlogans.Remove(slg);
            _context.SaveChanges();
        }

        public IEnumerable<BlogSlogan> GetSlogans()
        {
            return _context.BlogSlogans.ToList();
        }

        public BlogSlogan GetSloganById(int id)
        {
            return _context.BlogSlogans.Find(id);
        }

        public void UpdateSlogan(BlogSlogan blogCommentToUpdate, BlogSlogan model)
        {
            blogCommentToUpdate.Status = model.Status;
            blogCommentToUpdate.BlogId = model.BlogId;
            blogCommentToUpdate.Name = model.Name;
            blogCommentToUpdate.Text = model.Text;
            blogCommentToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }



    }
}
