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
    public class BlogPhotosController : Controller
    {
       
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IBlogRepository _blogRepository;
        private readonly IBlogPhotosRepository _blogPhotosRepository;
        public BlogPhotosController(IMapper mapper, IBlogRepository blogRepository, IBlogPhotosRepository blogPhotosRepository)
        {
            _mapper = mapper;
            _blogRepository = blogRepository;
            _blogPhotosRepository = blogPhotosRepository;
        }
        public IActionResult Index()
        {
            var blogPhotos= _blogPhotosRepository.GetBlogImages();
            var model = _mapper.Map<IEnumerable<BlogImage>, IEnumerable<BlogImageViewModel>>(blogPhotos);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Blogs = _blogRepository.GetBlogs();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogImageViewModel img)
        {
            if (ModelState.IsValid)
            {
                BlogImage model = _mapper.Map<BlogImageViewModel, BlogImage>(img);
                model.CreatedBy = _admin.FullName;
                _blogPhotosRepository.CreateFag(model);
                return RedirectToAction("index");
            }
            return View(img);
        }
        public IActionResult Edit(int id)
        {
            BlogImage img = _blogPhotosRepository.GetBlogPhotoById(id);
            if (img == null) return NotFound();
            var model = _mapper.Map<BlogImage, BlogImageViewModel>(img);
            ViewBag.Blogs = _blogRepository.GetBlogs();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogImageViewModel img)
        {
            if (ModelState.IsValid)
            {
                BlogImage model = _mapper.Map<BlogImageViewModel, BlogImage>(img);
                model.ModifiedBy = _admin.FullName;
                BlogImage BlogImageToUpdate = _blogPhotosRepository.GetBlogPhotoById(img.Id);
                if (BlogImageToUpdate == null) return NotFound();
                _blogPhotosRepository.UpdateFag(BlogImageToUpdate, model);
                return RedirectToAction("index");
            }
            return View(img);
        }
        public IActionResult Delete(int id)
        {
            BlogImage img = _blogPhotosRepository.GetBlogPhotoById(id);
            if (img == null) return NotFound();
            _blogPhotosRepository.DeleteFag(img);
            return RedirectToAction("index");
        }
    }
}