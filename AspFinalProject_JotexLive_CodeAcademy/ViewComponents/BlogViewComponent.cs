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
    public class BlogViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IBestServicesRepository _bestServicesRepository;
        public BlogViewComponent(IMapper mapper, IBestServicesRepository bestServicesRepository)
        {
            _mapper = mapper;
            _bestServicesRepository = bestServicesRepository;
        }
        public IViewComponentResult Invoke()
        {
            var bestServices = _bestServicesRepository.getBestServices(100);

            var model = _mapper.Map<IEnumerable<Service>, IEnumerable<BestServicesViewModel>>(bestServices);
            return View(model);
        }
    }
}
