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
    public class LikeableAreaViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly ILikeableAreaRepository _likeableAreaRepositry;
        public LikeableAreaViewComponent(IMapper mapper, ILikeableAreaRepository likeableAreaRepositry)
        {
            _mapper = mapper;
            _likeableAreaRepositry = likeableAreaRepositry;
        }
        public IViewComponentResult Invoke()
        {
            var likeableArea = _likeableAreaRepositry.GetLikeableAreas();

            var model = _mapper.Map<IEnumerable<LikeableArea>, IEnumerable<LikeableAreaViewModel>>(likeableArea);

            return View(model);
        }
    }
}
