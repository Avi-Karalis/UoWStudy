using UoWStudy.Core.Interfaces;
using UoWStudy.Core.Models;

namespace UoWStudy.Infrastructure.Repositories;
    public class ProductRepository : GenericRepository<Product>, IProductRepository {
        public ProductRepository(DbContextClass db) : base(db) {
            //In C#, when you create a derived class from a base class, the derived class constructor can call the
            //constructor of the base class using the base keyword.

            //In this case, base(db) is calling the constructor of the base class of ProductRepository.
            //By passing the db parameter to base(db), the DbContextClass
            //instance(db) is provided to the base class constructor.
            //This allows the base class to initialize its own state or perform any
            //necessary setup using the provided DbContextClass instance.

            //In essence, base(db) ensures that the base class constructor is called with the
            //appropriate argument(db) before any code specific to the ProductRepository constructor is executed.
            // ======================================================================================================
            // in short we are making sure the DbContextClass that was injected in the parent class (GenericReporistory)
            // is being implemented in the default constructor of the ProductRepository
        }

    }