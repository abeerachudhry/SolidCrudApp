using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SolidCrudApp.Models;

namespace SolidCrudApp.DataAccess.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductModel>> GetAllAsync();
        Task<ProductModel?> GetByIdAsync(Guid id);
        Task AddAsync(ProductModel product);
        Task UpdateAsync(ProductModel product);
        Task DeleteAsync(Guid id);
        Task<List<ProductModel>> SearchAsync(string keyword);
    }
}