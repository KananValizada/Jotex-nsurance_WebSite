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
    public class CaseStudiesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICaseStudyRepository _caseStudyRepository;
        public CaseStudiesController(IMapper mapper, ICaseStudyRepository caseStudyRepository)
        {
            _mapper = mapper;
            _caseStudyRepository = caseStudyRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CaseSingle(int Id)
        {
            var cases = _caseStudyRepository.GetCaseStudyById(Id);

            if (cases == null) return NotFound();

            var model = _mapper.Map<CaseStudy, CaseStudyViewModel>(cases);
            return View(model);
        }
    }
}