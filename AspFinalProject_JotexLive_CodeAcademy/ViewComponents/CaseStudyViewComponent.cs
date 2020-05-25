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
    public class CaseStudyViewComponent : ViewComponent
    {

        private readonly IMapper _mapper;
        private readonly ICaseStudyRepository _caseStudyRepository;
        public CaseStudyViewComponent(IMapper mapper, ICaseStudyRepository caseStudyRepository)
        {
            _mapper = mapper;
            _caseStudyRepository = caseStudyRepository;
        }
        public IViewComponentResult Invoke()
        {
            var caseStudies = _caseStudyRepository.GetCaseStudy();

            var model = _mapper.Map<IEnumerable<CaseStudy>, IEnumerable<CaseStudyViewModel>>(caseStudies);

            return View(model);
        }
    }
}
