using HelperStockBeta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperStockBeta.Domain.Interface
{
    public interface IProductRepository
    {
        //Assinaturas customizadas
        Task<IEnumerable<Product>> GetProductAsync();

        Task<Product> GetByIdAsync(int id);

        Task<Product> GetProductCategoryAsync(int id);
        // Assinaturas de CRUD

        Task<Category> CreateAsync(Product product);

        Task<Category> UpdateAsync(Product product);

        Task<Category> RemoveAsync(Product product);

    }
}
