using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspFinalProject_JotexLive_CodeAcademy.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;

namespace AspFinalProject_JotexLive_CodeAcademy.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAboutUsRepository _aboutUsRepository;
        public ContactController(IMapper mapper, IAboutUsRepository aboutUsRepository)
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