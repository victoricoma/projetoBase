using HelperStockBeta.Application.DTOs;

namespace HelperStockBeta.Application.Interfaces
{
    public interface ICategoryServices
    {
        Task<IEnumerable<CategoryDTO>> GetCategories();
        Task<CategoryDTO> GetById(int? id);

        Task Add(CategoryDTO categoryDTO);

        Task Update(CategoryDTO categoryDTO);

        Task remove(int? id);
    }
}
