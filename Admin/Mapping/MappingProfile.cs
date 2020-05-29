using Admin.Models.Pages;
using Admin.Models.Services;
using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Fag, FagViewModel>();
            CreateMap<FagViewModel, Fag>();
            CreateMap<Service, ServiceViewModel>();
            CreateMap<ServiceViewModel, Service>();
        }
    }
}
