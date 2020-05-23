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
    public class AgentViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IAboutUsRepository _aboutUsRepository;
        public AgentViewComponent(IMapper mapper, IAboutUsRepository aboutUsRepository)
        {
            _mapper = mapper;
            _aboutUsRepository = aboutUsRepository;
        }
        public IViewComponentResult Invoke()
        {
            var aboutUs = _aboutUsRepository.GetAboutUs();

            var model = _mapper.Map<IEnumerable<AboutUs>, IEnumerable<AboutUsViewModel>>(aboutUs);

            return View(model);
        }
    }
}
