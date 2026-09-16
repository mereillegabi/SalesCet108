using SalesCet108.Web.Data.Entities;

namespace SalesCet108.Web.Data
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DataContext context) : base(context)
        {
            
        }
    }
}
