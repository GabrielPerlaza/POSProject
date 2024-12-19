using POS.Domain.Entities;
using POS.Infrastructure.Commons.Base.Request;
using POS.Infrastructure.Commons.Base.Response;
using POS.Infrastructure.Persistences.Repositories;

namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface ICategoryRepository
    {
        Task<BaseEntityResponse<Category>> ListCategories(BaseFilterRequest filters);

        Task<IEnumerable<Category>> ListSelectCategories();

        Task<Category> CategoryById(int categoryid);

        Task<bool> RegisterCategory(Category category);

        Task<bool> EditCategory(Category category);

        Task<bool> RemoveCategory(int categoryid);






    }
}
