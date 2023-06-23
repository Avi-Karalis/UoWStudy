using Microsoft.EntityFrameworkCore;
using UoWStudy.Core.Interfaces;

namespace UoWStudy.Infrastructure.Repositories;
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class {
        // lines 12 and 15 inject the DBcontext to the Generic Repository and then we can Implement the interface normally
        // I used arrow function ( => ) to reduce line count. we can use normal block syntax
        // ( async Signature { return xxxx} ) to achieve the same thing.
        protected readonly DbContextClass _db;

        protected GenericRepository(DbContextClass db) => _db = db;

        public async Task Add(T entity) => await _db.AddAsync(entity);

        public void Delete(T entity) => _db.Set<T>().Remove(entity);

        public async Task<IEnumerable<T>> GetAll() => await _db.Set<T>().ToListAsync();

        public async Task<T> GetById(int id) => await _db.Set<T>().FindAsync(id);

        public void Update(T entity) => _db.Set<T>().Update(entity);
    }
