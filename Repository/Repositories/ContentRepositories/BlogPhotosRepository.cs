using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ContentRepositories
{
    public interface IBlogPhotosRepository
    {
        IEnumerable<BlogImage> GetBlogImages();
        void CreateFag(BlogImage model);
        BlogImage GetBlogPhotoById(int id);
        void UpdateFag(BlogImage blogImageToUpdate, BlogImage model);
        void DeleteFag(BlogImage img);
    }
    public class BlogPhotosRepository: IBlogPhotosRepository
    {
        private readonly JotexDbContext _context;
        public BlogPhotosRepository(JotexDbContext context)
        {
            _context = context;
        }

        public void CreateFag(BlogImage model)
        {
            model.CreatedAt = DateTime.Now;
            _context.BlogImages.Add(model);
            _context.SaveChanges();
        }

        public void DeleteFag(BlogImage img)
        {
            _context.BlogImages.Remove(img);
            _context.SaveChanges();
        }

        public IEnumerable<BlogImage> GetBlogImages()
        {
            return _context.BlogImages.ToList();
        }

        public BlogImage GetBlogPhotoById(int id)
        {
            return _context.BlogImages.Find(id);
        }

        public void UpdateFag(BlogImage blogImageToUpdate, BlogImage model)
        {
            blogImageToUpdate.Status = model.Status;
            blogImageToUpdate.Image = model.Image;
            blogImageToUpdate.BlogId = model.BlogId;
            blogImageToUpdate.ModifiedAt = DateTime.Now;
            _context.SaveChanges();
        }

    }
}
