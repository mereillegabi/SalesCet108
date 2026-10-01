namespace SalesCet108.Web.Data.Entities;

using System.ComponentModel.DataAnnotations;

public class State
{
    public int Id { get; set; }

    [Display(Name = "Nome da Província")]
    [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo 50 {1} caracteres!")]
    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "O campo {0} é obrigatório")]
    public Country Country { get; set; } = null!;

    public ICollection<City> Cities { get; set; } = null!;

    [Display(Name = "Número de Cidades")]
    public int CitiesNumber => Cities == null ? 0 : Cities.Count;
}