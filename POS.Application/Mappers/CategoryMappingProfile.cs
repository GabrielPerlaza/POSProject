using AutoMapper;
using POS.Application.Dto.Request;
using POS.Application.Dto.Response;
using POS.Domain.Entities;
using POS.Infrastructure.Commons.Base.Response;
using POS.Utilities;

namespace POS.Application.Mappers
{
    public class CategoryMappingProfile : Profile
    {
       public CategoryMappingProfile() 
        {
            CreateMap<Category, CategoryResponseDTO>()
               .ForMember(x => x.StateCategory, x => x.MapFrom(y => y.State.Equals((int)StateTypes.Active) ? "Activo" : "Inactivo"))
               .ReverseMap();

            CreateMap<BaseEntityResponse<Category>, BaseEntityResponse<CategoryResponseDTO>>()
                .ReverseMap();

            CreateMap<CategoryRequestDTO, Category>()
                .ReverseMap();

            CreateMap<Category, CategorySelectResponseDTO>()
                .ReverseMap();
        }
    }
}
