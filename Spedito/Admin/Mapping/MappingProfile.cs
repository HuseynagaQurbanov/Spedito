using SpeditoReposity.Models;
using AutoMapper;
using Admin.Models.Shopping;

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
        }
    }
}
