using Admin.Models.Account;
using Admin.Models.Blog;
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
            CreateMap<Settings, SettingsViewModel>();
            CreateMap<SettingsViewModel,Settings>();
            CreateMap<Blog, BlogViewModel>();
            CreateMap<BlogViewModel, Blog>();
            CreateMap<BlogImage, BlogImageViewModel>();
            CreateMap<BlogImageViewModel, BlogImage>();
            CreateMap<BlogComment, BlogCommentViewModel>();
            CreateMap<BlogCommentViewModel, BlogComment>();
            CreateMap<BlogSlogan, BlogSloganViewModel>();
            CreateMap<BlogSloganViewModel,BlogSlogan>();
            CreateMap<AboutUs, AboutUsViewModel>();
            CreateMap<AboutUsViewModel, AboutUs>();

        }
    }
}
