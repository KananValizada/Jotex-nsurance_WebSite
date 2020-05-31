using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspFinalProject_JotexLive_CodeAcademy.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;

namespace AspFinalProject_JotexLive_CodeAcademy.Controllers
{
    public class BlogController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBestServicesRepository _bestServicesRepository;
        public BlogController(IMapper mapper, IBestServicesRepository bestServicesRepository)
        {
            _mapper = mapper;
            _bestServicesRepository = bestServicesRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detailed(int Id)
        {
            var blog = _bestServicesRepository.GetBlogById(Id);

                if (blog == null) return NotFound();

            var model = _mapper.Map<Blog,BlogViewModel>(blog);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detailed(BlogViewModel Comment)
        {

            BlogComment blogComment = new BlogComment
            {
                ModifiedAt = DateTime.Now,
                Status =true,
                CreatedAt = DateTime.Now,
                CreatedBy = Comment.BlogComments[0].Name,
                ModifiedBy = Comment.BlogComments[0].Name,
                Name = Comment.BlogComments[0].Name,
                Text = Comment.BlogComments[0].Text,
                BlogId =Comment.BlogComments[0].BlogId,
                Image = "#"
            };

            _bestServicesRepository.PostBlogComment(blogComment);

            var blog = _bestServicesRepository.GetBlogById(Comment.BlogComments[0].BlogId);

            if (blog == null) return NotFound();

            var model = _mapper.Map<Blog, BlogViewModel>(blog);

            return View(model);
        }
    }
}