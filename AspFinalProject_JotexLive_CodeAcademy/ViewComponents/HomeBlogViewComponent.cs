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
    public class HomeBlogViewComponent : ViewComponent
    {
            private readonly IMapper _mapper;
            private readonly IBestServicesRepository _bestSetvicesRepository;
            public HomeBlogViewComponent(IMapper mapper, IBestServicesRepository bestSetvicesRepository)
            {
                _mapper = mapper;
                _bestSetvicesRepository = bestSetvicesRepository;
            }
            public IViewComponentResult Invoke()
            {
                var services = _bestSetvicesRepository.getBestServices(7);

                var model = _mapper.Map<IEnumerable<Service>, IEnumerable<BestServicesViewModel>>(services);

                return View(model);
            }
        }
    }

