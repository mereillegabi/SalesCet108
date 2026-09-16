using SalesCet108.Web.Data.Entities;
using SalesCet108.Web.Models;

namespace SalesCet108.Web.Helpers
{
    public interface IConverterHelper
    {
        Product ToProduct(ProductViewModel model, string path, bool isNew);
        Product ToProductViewModel(Product product);
    }
}
