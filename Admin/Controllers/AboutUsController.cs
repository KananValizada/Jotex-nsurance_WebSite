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
    public class AboutUsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IAboutUsRepository _aboutUsRepository;
        public AboutUsController(IMapper mapper, IAboutUsRepository aboutUsRepository)
        {
            _mapper = mapper;
            _aboutUsRepository = aboutUsRepository;
        }
        public IActionResult Index()
        {
            var aboutUs = _aboutUsRepository.GetAboutUsAll();
            var model = _mapper.Map<IEnumerable<AboutUs>, IEnumerable<AboutUsViewModel>>(aboutUs);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Settings = _aboutUsRepository.GetSettings();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AboutUsViewModel abs)
        {
            if (ModelState.IsValid)
            {
                AboutUs model = _mapper.Map<AboutUsViewModel, AboutUs>(abs);
                model.CreatedBy = _admin.FullName;
                model.ClaimActionText= model.OfficeActionText;
                model.PolicyActionText = model.OfficeActionText;
                _aboutUsRepository.CreateAbout(model);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Edit(int id)
        {
            AboutUs abs = _aboutUsRepository.GetAboutUsById(id);
            if (abs == null) return NotFound();
            var model = _mapper.Map<AboutUs, AboutUsViewModel>(abs);
            ViewBag.Settings = _aboutUsRepository.GetSettings();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AboutUsViewModel abs)
        {
            if (ModelState.IsValid)
            {
                AboutUs model = _mapper.Map<AboutUsViewModel, AboutUs>(abs);
                model.ModifiedBy = _admin.FullName;
                AboutUs AboutUsToUpdate = _aboutUsRepository.GetAboutUsById(abs.Id);
                if (AboutUsToUpdate == null) return NotFound();
                _aboutUsRepository.UpdateAboutUs(AboutUsToUpdate, model);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            AboutUs abs = _aboutUsRepository.GetAboutUsById(id);
            if (abs == null) return NotFound();
            _aboutUsRepository.DeleteAbout(abs);
            return RedirectToAction("index");
        }
    }
}