using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IBlogCommentsRepository
    {
        IEnumerable<BlogComment> GetComments();
        void CreateComment(BlogComment model);
        BlogComment GetCommentById(int id);
        void UpdateComment(BlogComment blogCommentToUpdate, BlogComment model);
        void DeleteComment(BlogComment img);
    }
    public class BlogCommentsRepository : IBlogCommentsRepository
    {
        private readonly JotexDbContext _context;
        public BlogCommentsRepository(JotexDbContext context)
        {
            _context = context;
        }

        public void CreateComment(BlogComment model)
        {
            model.CreatedAt = DateTime.Now;
            _context.BlogComments.Add(model);
            _context.SaveChanges();
        }

        public void DeleteComment(BlogComment img)
        {
            _context.BlogComments.Remove(img);
            _context.SaveChanges();
        }

        public IEnumerable<BlogComment> GetComments()
        {
            return _context.BlogComments.ToList();
        }

        public BlogComment GetCommentById(int id)
        {
            return _context.BlogComments.Find(id);
        }

        public void UpdateComment(BlogComment blogCommentToUpdate, BlogComment model)
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
