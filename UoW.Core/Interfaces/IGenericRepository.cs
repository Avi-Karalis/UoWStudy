namespace UoWStudy.Core.Interfaces;
    public interface IGenericRepository<T> where T: class {
        // give basic functions to be inherited
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

