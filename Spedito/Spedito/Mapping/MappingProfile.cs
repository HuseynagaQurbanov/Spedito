using Spedito.Models;
using AutoMapper;
using SpeditoReposity.Models;
using System.Linq;
using Spedito.Models.Account;

namespace Spedito.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SliderItem, SliderItemViewModel>();
            CreateMap<FoodCategory, FoodCatalogViewModel>();
            CreateMap<FirstScreenTitle, FirstScreenTitleViewModel>();
            CreateMap<Product, ProductViewModel>()
                     .ForMember(d => d.Photos, opt => opt.MapFrom(src => src.Photos.OrderBy(p => p.OrderBy).Select(p => p.Image)));
            CreateMap<AboutUsSection, AboutUsViewModel>();
            CreateMap<Feature, FeatureViewModel>();
            CreateMap<Step, StepViewModel>();
            CreateMap<RegisterViewModel, User>();
            CreateMap<ProductReview, ReviewViewModel>();
            CreateMap<ProductOptionItem, OptionItemViewModel>();
            CreateMap<ProductOption, OptionsViewModel>();
        }
    }
}
