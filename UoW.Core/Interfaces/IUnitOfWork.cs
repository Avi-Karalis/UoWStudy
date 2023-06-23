namespace UoWStudy.Core.Interfaces;
    public interface IUnitOfWork : IDisposable {
        // we give access to the IUoW to access ProductRepo via polymorphism
        IProductRepository ProductRepo { get; }
        int Save();
    }

