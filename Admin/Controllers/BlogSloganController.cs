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
    public class BlogSloganController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IBlogSloganRepository _blogSloganRepository;
        private readonly IBlogRepository _blogRepository;
        public BlogSloganController(IMapper mapper, IBlogSloganRepository blogSloganRepository, IBlogRepository blogRepository)
        {
            _mapper = mapper;
            _blogSloganRepository = blogSloganRepository;
            _blogRepository = blogRepository;
        }
        public IActionResult Index()
        {
            var comments = _blogSloganRepository.GetSlogans();
            var model = _mapper.Map<IEnumerable<BlogSlogan>, IEnumerable<BlogSloganViewModel>>(comments);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Blogs = _blogRepository.GetBlogs();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BlogSloganViewModel slg)
        {
            if (ModelState.IsValid)
            {
                BlogSlogan model = _mapper.Map<BlogSloganViewModel, BlogSlogan>(slg);
                model.CreatedBy = _admin.FullName;
                model.Image = "author.jpg";
                _blogSloganRepository.CreateSlogan(model);
                return RedirectToAction("index");
            }
           
            return View(slg);
        }
        public IActionResult Edit(int id)
        {
            BlogSlogan slg = _blogSloganRepository.GetSloganById(id);
            if (slg == null) return NotFound();
            var model = _mapper.Map<BlogSlogan, BlogSloganViewModel>(slg);
            ViewBag.Blogs = _blogRepository.GetBlogs();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BlogSloganViewModel slg)
        {
            if (ModelState.IsValid)
            {
                BlogSlogan model = _mapper.Map<BlogSloganViewModel, BlogSlogan>(slg);
                model.ModifiedBy = _admin.FullName;
                BlogSlogan BlogSloganToUpdate = _blogSloganRepository.GetSloganById(slg.Id);
                if (BlogSloganToUpdate == null) return NotFound();
                _blogSloganRepository.UpdateSlogan(BlogSloganToUpdate, model);
                return RedirectToAction("index");
            }
            return View(slg);
        }
        public IActionResult Delete(int id)
        {
            BlogSlogan slg = _blogSloganRepository.GetSloganById(id);
            if (slg == null) return NotFound();
            _blogSloganRepository.DeleteSlogan(slg);
            return RedirectToAction("index");
        }
    }
}