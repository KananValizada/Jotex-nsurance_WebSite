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
    public class FagViewComponent :ViewComponent
    {

        private readonly IMapper _mapper;
        private readonly IFagRepository _fagRepository;
        public FagViewComponent(IMapper mapper, IFagRepository fagRepository)
        {
            _mapper = mapper;
            _fagRepository = fagRepository;
        }
        public IViewComponentResult Invoke()
        {
            var fags = _fagRepository.GetFags(4);

            var model = _mapper.Map<IEnumerable<Fag>, IEnumerable<FagViewModel>>(fags);

            return View(model);
        }
    }
}
