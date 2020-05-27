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
    public class FaqController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFagRepository _fagRepository;
        public FaqController(IMapper mapper,IFagRepository fagRepository)
        {
            _mapper = mapper;
            _fagRepository = fagRepository;
        }
        public IActionResult Index()
        {
            var fags = _fagRepository.GetFags(4);
            var model = _mapper.Map<IEnumerable<Fag> , IEnumerable<FagViewModel>>(fags);
            return View(model);
        }
        public IActionResult Create()
        {

            return View();
        }
    }
}