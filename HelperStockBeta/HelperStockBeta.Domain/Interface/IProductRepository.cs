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
        //Assinaturas Customizadas
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetByIdAsync (int? id);
        Task<Product> GetProductCategoryAsync(int? id);

        //Assinaturas do CRUD
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> RemoveAsync(Product product);

    }
}
