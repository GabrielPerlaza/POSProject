using POS.Application.Commom.Base;
using POS.Application.Dto.Request;
using POS.Application.Dto.Response;
using POS.Infrastructure.Commons.Base.Request;
using POS.Infrastructure.Commons.Base.Response;

namespace POS.Application.Interfaces
{
    public interface ICategoryApplication
    {
        Task<BaseResponse<BaseEntityResponse<CategoryResponseDTO>>> ListCategories(BaseFilterRequest filtros);
        Task<BaseResponse<IEnumerable<CategorySelectResponseDTO>>> ListSelectCategories();
        Task<BaseResponse<CategoryResponseDTO>> CategoryById (int categoryid);
        Task<BaseResponse<bool>> RegisterCategory(CategoryRequestDTO requestDTO);
        Task<BaseResponse<bool>> EditCategory(int categoryId, CategoryRequestDTO requestDTO);
        Task<BaseResponse<bool>> RemoveCategory(int categoryid);



    }
}
