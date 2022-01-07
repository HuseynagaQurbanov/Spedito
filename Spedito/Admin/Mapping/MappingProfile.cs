using SpeditoReposity.Models;
using AutoMapper;
using Admin.Models.Shopping;
using Admin.Models.Content;

namespace Spedito.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FoodCategory, CategoryViewModel>();
            CreateMap<CategoryViewModel, FoodCategory>();

            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();

            CreateMap<ProductPhoto, ProductPhotoViewModel>();
            CreateMap<ProductPhotoViewModel, ProductPhoto>();

            CreateMap<AboutUsSection, AboutUsViewModel>();
            CreateMap<AboutUsViewModel, AboutUsSection >();

            CreateMap<Feature, FeatureViewModel>();
            CreateMap<FeatureViewModel, Feature>();

            CreateMap<Step, StepViewModel>();
            CreateMap<StepViewModel, Step>();
        }
    }
}
