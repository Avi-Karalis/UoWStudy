using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UoWStudy.Core.Interfaces {
    public interface IUnitOfWork : IDisposable {
        // we give access to the IUoW to access ProductRepo via polymorphism
        IProductRepository ProductRepo { get; }
    }
}
