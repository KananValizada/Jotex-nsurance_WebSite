using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Admin.Libs;
using Admin.Models.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ContentRepositories;
using Repository.Services;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class ServicesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IBestServicesRepository _servicesRepository;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly IFileManager _fileManager;

        public ServicesController(IMapper mapper, 
                                  IBestServicesRepository servicesRepository, 
                                  ICloudinaryService cloudinaryService,
                                  IFileManager fileManager)
        {
            _mapper = mapper;
            _servicesRepository = servicesRepository;
            _cloudinaryService = cloudinaryService;
            _fileManager = fileManager;
        }
        public IActionResult Index()
        {
            var list =  _servicesRepository.getServices();
            var model = _mapper.Map<IEnumerable<Service>, IEnumerable<ServiceViewModel>>(list);

            return View(model);
        }
        public IActionResult Edit(int Id)
        {
            var model = _servicesRepository.getServiceById(Id);
            if (model == null) NotFound();
            var service = _mapper.Map<Service, ServiceViewModel>(model);
            return View(service);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ServiceViewModel service)
        {
            if (ModelState.IsValid)
            {
                Service model = _mapper.Map<ServiceViewModel,Service>(service);
                model.ModifiedBy = _admin.FullName;
                Service serviseToUpdate = _servicesRepository.getServiceById(service.Id);
                if (serviseToUpdate == null) return NotFound();
                _servicesRepository.UpdateServise(serviseToUpdate, model);
                return RedirectToAction("index");
            }
            return View(service);
        }

        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            var filename = _fileManager.Upload(file);
            var publicId = _cloudinaryService.Store(filename);
            _fileManager.Delete(filename);
            return Ok(new { 
                filename = publicId,
                src = _cloudinaryService.BuildUrl(publicId)
            });
        }

        public IActionResult Remove(string name)
        {
            _cloudinaryService.Delete(name);
            return Ok(new { status = 200 });

        }

        public IActionResult Delete(int id)
        {
            Service service = _servicesRepository.getServiceById(id);
            if (service == null) return NotFound();
            _servicesRepository.DeleteServise(service);
            return RedirectToAction("index");
        }
    }
}