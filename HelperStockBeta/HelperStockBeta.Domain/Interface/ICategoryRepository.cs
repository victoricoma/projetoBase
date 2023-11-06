using HelperStockBeta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperStockBeta.Domain.Interface
{
    public interface ICategoryRepository
    {
        //Assinaturas Customizadas.
        Task <IEnumerable<Category>> GetCategoriesAsync ();
        Task<Category> GetByIdAsync(int? id);

        //Assinaturas de CRUD
        Task<Category> CreateAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<Category> RemoveAsync(Category category);
    }
}
