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
    public class CaseStudiesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IMapper _mapper;
        private readonly ICaseStudyRepository _casestudyRepository;
        private readonly IAgentRepository _agentRepository;
        public CaseStudiesController(IMapper mapper, ICaseStudyRepository casestudyRepository,
                                                IAgentRepository agentRepository)
        {
            _mapper = mapper;
            _casestudyRepository = casestudyRepository;
            _agentRepository = agentRepository;

        }
        public IActionResult Index()
        {
            var cases = _casestudyRepository.GetAllCaseStudies();
            var model = _mapper.Map<IEnumerable<CaseStudy>, IEnumerable<CaseStudyViewModel>>(cases);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Agents = _agentRepository.GetAllAgents();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CaseStudyViewModel abs)
        {
            if (ModelState.IsValid)
            {
                CaseStudy model = _mapper.Map<CaseStudyViewModel, CaseStudy>(abs);
                model.CreatedBy = _admin.FullName;
                _casestudyRepository.CreateCaseStudy(model);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Edit(int id)
        {
            CaseStudy abs = _casestudyRepository.GetCaseStudyById(id);
            if (abs == null) return NotFound();
            var model = _mapper.Map<CaseStudy, CaseStudyViewModel>(abs);
            ViewBag.Agents = _agentRepository.GetAllAgents();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CaseStudyViewModel abs)
        {
            if (ModelState.IsValid)
            {
                CaseStudy model = _mapper.Map<CaseStudyViewModel, CaseStudy>(abs);
                model.ModifiedBy = _admin.FullName;
                CaseStudy TestToUpdate = _casestudyRepository.GetCaseStudyById(abs.Id);
                if (TestToUpdate == null) return NotFound();
                _casestudyRepository.UpdateCaseStudy(TestToUpdate, model);
                return RedirectToAction("index");
            }
            return View(abs);
        }
        public IActionResult Delete(int id)
        {
            CaseStudy abs = _casestudyRepository.GetCaseStudyById(id);
            if (abs == null) return NotFound();
            _casestudyRepository.DeleteCaseStudy(abs);
            return RedirectToAction("index");
        }
    }
}