using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoWStudy.Core.Models;

namespace UoWStudy.Core.Interfaces {
    public interface IProductRepository : IGenericRepository<Product> {

        // the product repository will now inherit IGenericRepo where T will be Product it's like :
        //Task<Product> GetById(int id);
        //Task<IEnumerable<Product>> GetAll();
        //Task Add(Product entity);
        //Task Update(Product entity);
        //Task Delete(int id);
        // being written here
    }
}
