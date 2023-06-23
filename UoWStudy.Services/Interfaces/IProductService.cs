using UoWStudy.Core.Models;
namespace UoWStudy.Services.Interfaces;
//again using an interface define how the Product service will behave. We can add an extra level of abstraction
// by adding an IGenericService
    public interface IProductService {
        Task<bool> CreateProduct(Product product);
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int id);
    }