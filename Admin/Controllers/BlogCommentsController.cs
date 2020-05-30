using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Blog;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class BlogCommentsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IBlogCommentsRepository _blogCommentsRepository;
        private readonly IBlogRepository _blogRepository;
        public BlogCommentsController(IMapper mapper, IBlogCommentsRepository blogCommentsRepository, IBlogRepository blogRepository)
        {
            _mapper = mapper;
            _blogCommentsRepository = blogCommentsRepository;
            _blogRepository = blogRepository;
        }
        public IActionResult Index()
        {
            var comments = _blogCommentsRepository.GetComments();
            var model = _mapper.Map<IEnumerable<BlogComment>, IEnumerable<BlogCommentViewModel>>(comments);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Blogs = _blogRepository.GetBlogs();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogCommentViewModel cmt)
        {
            if (ModelState.IsValid)
            {
                BlogComment model = _mapper.Map<BlogCommentViewModel, BlogComment>(cmt);
                model.CreatedBy = _admin.FullName;
                model.Image = "#";
                _blogCommentsRepository.CreateComment(model);
                return RedirectToAction("index");
            }
            return View(cmt);
        }
        public IActionResult Edit(int id)
        {
            BlogComment cmt = _blogCommentsRepository.GetCommentById(id);
            if (cmt == null) return NotFound();
            var model = _mapper.Map<BlogComment, BlogCommentViewModel>(cmt);
            ViewBag.Blogs = _blogRepository.GetBlogs();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogCommentViewModel cmt)
        {
            if (ModelState.IsValid)
            {
                BlogComment model = _mapper.Map<BlogCommentViewModel, BlogComment>(cmt);
                model.ModifiedBy = _admin.FullName;
                BlogComment BlogImageToUpdate = _blogCommentsRepository.GetCommentById(cmt.Id);
                if (BlogImageToUpdate == null) return NotFound();
                _blogCommentsRepository.UpdateComment(BlogImageToUpdate, model);
                return RedirectToAction("index");
            }
            return View(cmt);
        }
        public IActionResult Delete(int id)
        {
            BlogComment cmt = _blogCommentsRepository.GetCommentById(id);
            if (cmt == null) return NotFound();
            _blogCommentsRepository.DeleteComment(cmt);
            return RedirectToAction("index");
        }
    }
}