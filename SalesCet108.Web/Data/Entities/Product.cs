using System.ComponentModel.DataAnnotations;

namespace SalesCet108.Web.Data.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres.")]
        public string Name { get; set; } = null;


        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        [Display(Name = "Imagem")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Última compra")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "Última venda")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Disponível")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Estoque")]
        public double Stock { get; set; }


    }
}
