using SalesCet108.Web.Data.Entities;
using SalesCet108.Web.Models;

namespace SalesCet108.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        public Product ToProduct(ProductViewModel model, string path, bool isNew) => new Product
        {
            Id = isNew ? 0 : model.Id,
            ImageUrl = path,
            IsAvailable = model.IsAvailable,
            LastPurchase = model.LastPurchase,
            LastSale = model.LastSale,
            Name = model.Name,
            Price = model.Price,
            Stock = model.Stock
        };

        public Product ToProductViewModel(Product product) => new ProductViewModel
        {
            Id = product.Id,
            ImageUrl = product.ImageUrl,
            IsAvailable = product.IsAvailable,
            LastPurchase = product.LastPurchase,
            LastSale = product.LastSale,
            Name = product.Name,
            Price = product.Price,
            Stock = product.Stock
        };
    }
}
