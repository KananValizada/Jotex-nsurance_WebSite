using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Models.Pages;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class TestimonialController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly ITestimonialRepository _testimonialRepository;
        private readonly IAboutUsRepository _aboutUsRepository;
        private readonly IBestServicesRepository _servicesRepository;
        public TestimonialController(IMapper mapper, ITestimonialRepository testimonialRepository, 
                                                IAboutUsRepository aboutUsRepository,
                                                IBestServicesRepository servicesRepository)
        {
            _mapper = mapper;
            _aboutUsRepository = aboutUsRepository;
            _testimonialRepository = testimonialRepository;
            _servicesRepository = servicesRepository;

        }
        public IActionResult Index()
        {
            var test = _testimonialRepository.GetTestimonials();
            var model = _mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialVieModel>>(test);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.AboutUs = _aboutUsRepository.GetAboutUsAll();
            ViewBag.Service = _servicesRepository.getServices();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TestimonialVieModel abs)
        {
            if (ModelState.IsValid)
            {
                Testimonial model = _mapper.Map<TestimonialVieModel, Testimonial>(abs);
                model.CreatedBy = _admin.FullName;
                _testimonialRepository.CreateTestimonial(model);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Edit(int id)
        {
            Testimonial abs = _testimonialRepository.GetTestimonialById(id);
            if (abs == null) return NotFound();
            var model = _mapper.Map<Testimonial, TestimonialVieModel>(abs);
            ViewBag.AboutUs = _aboutUsRepository.GetAboutUsAll();
            ViewBag.Service = _servicesRepository.getServices();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TestimonialVieModel abs)
        {
            if (ModelState.IsValid)
            {
                Testimonial model = _mapper.Map<TestimonialVieModel, Testimonial>(abs);
                model.ModifiedBy = _admin.FullName;
                Testimonial TestToUpdate = _testimonialRepository.GetTestimonialById(abs.Id);
                if (TestToUpdate == null) return NotFound();
                _testimonialRepository.UpdateTestimonial(TestToUpdate, model);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            Testimonial abs = _testimonialRepository.GetTestimonialById(id);
            if (abs == null) return NotFound();
            _testimonialRepository.DeleteTestimonial(abs);
            return RedirectToAction("index");
        }
    }
}