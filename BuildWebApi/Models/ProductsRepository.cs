using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildWebApi.Models
{
    public class ProductsRepository : DbContext
    {
        public ProductsRepository(DbContextOptions<ProductsRepository> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        internal Task<List<Product>> GetDiscontinuedProductsAsync()
        {
            throw new NotImplementedException();
        }

        internal Task<List<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
