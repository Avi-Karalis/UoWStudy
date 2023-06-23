using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoWStudy.Core.Interfaces;
namespace UoWStudy.Infrastructure.Repositories {
    public class UnitOfWork : IUnitOfWork {
        // we inject the ProductRepo and the DBContext to the overloaded Ctor of the Unit of work.
        public IProductRepository ProductRepo { get; }

        protected readonly DbContextClass _db;

        public UnitOfWork(DbContextClass db, IProductRepository productRepo)
        {
           _db = db;
            ProductRepo = productRepo;
        }

        public int Save() => _db.SaveChanges();

        //The Dispose method is called to clean up and release resources held by an object,
        //and in this code, it specifically disposes of a resource called _dbContext.
        //By implementing the Dispose pattern, we ensure proper cleanup and
        //resource release when we're done using the object.
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) {
            if (disposing) {
                _db.Dispose();
            }
        }
    }
}
