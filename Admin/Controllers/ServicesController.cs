using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.ContentRepositories;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class ServicesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IBestServicesRepository _servicesRepository;

        public ServicesController(IMapper mapper, IBestServicesRepository servicesRepository)
        {
            _mapper = mapper;
            _servicesRepository = servicesRepository;
        }
        public IActionResult Index()
        {
            var list =  _servicesRepository.getServices();

            return View();
        }
    }
}