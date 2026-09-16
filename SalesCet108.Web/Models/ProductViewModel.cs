using SalesCet108.Web.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace SalesCet108.Web.Models
{
    public class ProductViewModel : Product
    {
        [Display(Name = "Imagem")]
        public IFormFile? ImageFile { get; set; } 
    }
}
