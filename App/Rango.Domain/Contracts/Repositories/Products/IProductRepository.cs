using Rango.Domain.Contracts.Repositories.Base;
using Rango.Domain.Entities.Products;

namespace Rango.Domain.Contracts.Repositories.Products
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}