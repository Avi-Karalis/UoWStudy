using Microsoft.EntityFrameworkCore;
using UoWStudy.Core.Models;

namespace UoWStudy.Infrastructure;
    public class DbContextClass : DbContext {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
            //The constructor DbContextClass(DbContextOptions<DbContextClass> options) : base(options) is defined
            //to initialize the DbContextClass instance.
            //It calls the base class constructor passing the options parameter to set up the database connection
            //and configuration.  
        }
        public DbSet<Product> Products { get; set; }
    }