using AspFinalProject_JotexLive_CodeAcademy.Models;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinalProject_JotexLive_CodeAcademy.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SliderItem, SliderItemViewModel>();
        }
        
    }
}
