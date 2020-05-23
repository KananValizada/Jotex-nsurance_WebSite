using AspFinalProject_JotexLive_CodeAcademy.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinalProject_JotexLive_CodeAcademy.ViewComponents
{
    public class TestimonialViewComponent :ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly ITestimonialsRepository _testimonialsRepository;
        public TestimonialViewComponent(IMapper mapper, ITestimonialsRepository testimonialsRepository)
        {
            _mapper = mapper;
            _testimonialsRepository = testimonialsRepository;
        }
        public IViewComponentResult Invoke()
        {
            var testimonials = _testimonialsRepository.GetTestimonials();

            var model = _mapper.Map<IEnumerable<Testimonial>, IEnumerable<TestimonialViewModel>>(testimonials);

            return View(model);
        }
    }
}
