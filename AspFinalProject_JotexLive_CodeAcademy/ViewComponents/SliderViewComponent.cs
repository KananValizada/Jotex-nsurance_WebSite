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
    public class SliderViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly ISliderRepository _sliderRepository;
        public SliderViewComponent(IMapper mapper,ISliderRepository sliderRepository)
        {
            _mapper = mapper;
            _sliderRepository = sliderRepository;
        }
        public IViewComponentResult Invoke()
        {
            var sliderItems = _sliderRepository.GetSliderItems();

            var model = _mapper.Map<IEnumerable<SliderItem>, IEnumerable<SliderItemViewModel>>(sliderItems);

            return View(model);
        }
    }
}
