using Microsoft.EntityFrameworkCore;
using SalesCet108.Web.Data.Entities;

namespace SalesCet108.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
