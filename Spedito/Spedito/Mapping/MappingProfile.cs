using Spedito.Models;
using AutoMapper;
using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spedito.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SliderItem, SliderItemViewModel>();
            CreateMap<FoodCollection, FoodCollectionViewModel>();
            CreateMap<FirstScreenTitle, FirstScreenTitleViewModel>();
            CreateMap<Product, ProductViewModel>()
                     .ForMember(d => d.Photos, opt => opt.MapFrom(src => src.Photos.OrderBy(p => p.OrderBy).Select(p => p.Image)));
            CreateMap<AboutUsSection, AboutUsViewModel>();
            CreateMap<Feature, FeatureViewModel>();
            CreateMap<Step, StepViewModel>();
        }
    }
}
