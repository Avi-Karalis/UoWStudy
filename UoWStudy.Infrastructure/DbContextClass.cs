using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UoWStudy.Core.Models;

namespace UoWStudy.Infrastructure {
    public class DbContextClass : DbContext {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
    }
}
