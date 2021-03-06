﻿using AspFinalProject_JotexLive_CodeAcademy.Models;
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
            CreateMap<Settings, SettingsViewModel>();
            CreateMap<Agent, AgentViewModel>();
            CreateMap<AboutUs, AboutUsViewModel>();
            CreateMap<BlogSlogan, BlogSloganViewModel>();
            CreateMap<BlogImage, BlogImageViewModel>();
            CreateMap<Blog, BlogViewModel>();
            CreateMap<ServiceSpec, ServiceSpecViewModel>();
            CreateMap<ServiceFeature, ServiceFeatureViewModel>();
            CreateMap<Service, BestServicesViewModel>();
            CreateMap<LikeableArea, LikeableAreaViewModel>();
            CreateMap<ClaimSettlementOption, ClaimSettlementOptionViewModel>();
            CreateMap<ClaimSettlement, ClaimSettlementViewModel>();
            CreateMap<Testimonial, TestimonialViewModel>();
            CreateMap<Award, AwardViewModel>();
            CreateMap<Fag, FagViewModel>();
            CreateMap<StudySpec, StudySpecsViewModel>();
            CreateMap<CaseStudy, CaseStudyViewModel>();



        }
        
    }
}
