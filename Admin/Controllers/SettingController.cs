using Admin.Filters;
using Admin.Libs;
using Admin.Models.Account;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using Repository.Services;
using System.Collections;
using System.Collections.Generic;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class SettingController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IAboutUsRepository _aboutUsRepository;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly IFileManager _fileManager;
        public SettingController(IMapper mapper,
                                  IAboutUsRepository aboutUsRepository,
                                  ICloudinaryService cloudinaryService,
                                  IFileManager fileManager)
        {
            _mapper = mapper;
            _aboutUsRepository = aboutUsRepository;
            _cloudinaryService = cloudinaryService;
            _fileManager = fileManager;
        }
        public IActionResult Index()
        {
            var list = _aboutUsRepository.GetAllSettings();
            var model = _mapper.Map<IEnumerable<Settings>, IEnumerable<SettingsViewModel>>(list);
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SettingsViewModel setting)
        {
            if (ModelState.IsValid)
            {
                Settings model = _mapper.Map<SettingsViewModel, Settings>(setting);
                model.CreatedBy = _admin.FullName;
                _aboutUsRepository.CreateSetting(model);
                return RedirectToAction("index");
            }
            return View(setting);
        }

        public IActionResult Edit(int Id)
        {

            Settings setting = _aboutUsRepository.GetSettingById(Id);
            if (setting == null) return NotFound();
            var model = _mapper.Map<Settings, SettingsViewModel>(setting);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SettingsViewModel setting)
        {
            if (ModelState.IsValid)
            {
                Settings model = _mapper.Map<SettingsViewModel, Settings>(setting);
                model.ModifiedBy = _admin.FullName;
                Settings settingToUpdate = _aboutUsRepository.GetSettingById(setting.Id);
                if (settingToUpdate == null) return NotFound();
                _aboutUsRepository.UpdateFag(settingToUpdate, model);
                return RedirectToAction("index");
            }
            return View(setting);
        }
        public IActionResult Delete(int id)
        {
            Settings setting = _aboutUsRepository.GetSettingById(id);
            if (setting == null) return NotFound();
            _aboutUsRepository.DeleteFag(setting);
            return RedirectToAction("index");
        }
    }
}