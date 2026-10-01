namespace SalesCet108.Web.Data.Entities;

using System.ComponentModel.DataAnnotations;

public class City
{
    public int Id { get; set; }

    [Display(Name = "Nome da Cidade")]
    [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo 50 {1} caracteres!")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Name { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public State State { get; set; }
}