using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspFinalProject_JotexLive_CodeAcademy.Models;
using AutoMapper;
using Repository.Repositories.ContentRepositories;
using Repository.Models;

namespace AspFinalProject_JotexLive_CodeAcademy.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAboutUsRepository _aboutUsRepository;
        public HomeController(IMapper mapper, IAboutUsRepository aboutUsRepository)
        {
            _mapper = mapper;
            _aboutUsRepository = aboutUsRepository;
        }
        public IActionResult Index()
        {
            var settings = _aboutUsRepository.GetSettings();
            var model = _mapper.Map<Settings, SettingsViewModel>(settings);
            return View(model);
        }

    }
}
