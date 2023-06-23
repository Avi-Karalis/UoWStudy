using System.Xml.Linq;
using UoWStudy.Core.Interfaces;
using UoWStudy.Core.Models;
using UoWStudy.Services.Interfaces;

namespace UoWStudy.Services {
    public class ProductService : IProductService {
        // we inject the UoW to the Service.
        public IUnitOfWork _unit;
        public ProductService(IUnitOfWork unit) => _unit = unit;

        public async Task<bool> CreateProduct(Product product) {
            if (product != null) { 
                await _unit.ProductRepo.Add(product);
                var result = _unit.Save();
                if (result > 0) {
                    return true;
                } else { 
                    return false;
                }
            }
            return false;
        }

        public async Task<bool> DeleteProduct(int id) {
            if (id > 0) {
                var productDetails = await _unit.ProductRepo.GetById(id);
                if (productDetails != null) {
                    _unit.ProductRepo.Delete(productDetails);
                    var result = _unit.Save();
                    if (result > 0) {
                        return true;
                    } else {
                        return false;
                    }
                }
            }
            return false;
        }

        public Task<IEnumerable<Product>> GetAll() => _unit.ProductRepo.GetAll();

        public async Task<Product> GetById(int id) {
            if (id > 0) {
                var product = await _unit.ProductRepo.GetById(id);
                if (product != null) {
                    return product;
                }
            }
            return null;
        }

        public async Task<bool> UpdateProduct(Product product) {
            if (product != null) {
                var productToUpdate = await _unit.ProductRepo.GetById(product.Id);
                // if DTOs are used, use AutoMapper.
                if (productToUpdate != null) {
                    productToUpdate.Name = product.Name;
                    productToUpdate.Description = product.Description;
                    productToUpdate.Price = product.Price;
                    productToUpdate.Stock = product.Stock;
                    _unit.ProductRepo.Update(productToUpdate);

                    var result = _unit.Save();
                    if (result > 0) {
                        return true;
                    } else {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
