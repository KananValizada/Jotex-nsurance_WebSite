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
    public class AwardViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IAwardsRepository _awardsRepository;
        public AwardViewComponent(IMapper mapper, IAwardsRepository awardsRepository)
        {
            _mapper = mapper;
            _awardsRepository = awardsRepository;
        }
        public IViewComponentResult Invoke()
        {
            var awards = _awardsRepository.GetAwards();

            var model = _mapper.Map<IEnumerable<Award>, IEnumerable<AwardViewModel>>(awards);

            return View(model);
        }
    }
}
