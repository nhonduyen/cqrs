using CQRS.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Infrastructure.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
