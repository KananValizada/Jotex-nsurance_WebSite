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
    public class ServicesViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IBestServicesRepository _servicesRepository;
        public ServicesViewComponent(IMapper mapper, IBestServicesRepository servicesRepository)
        {
            _mapper = mapper;
            _servicesRepository = servicesRepository;
        }
        public IViewComponentResult Invoke()
        {
            var services = _servicesRepository.getBestServices(6);

            var model = _mapper.Map<IEnumerable<Service>, IEnumerable<BestServicesViewModel>>(services);

            return View(model);
        }
    }
}
