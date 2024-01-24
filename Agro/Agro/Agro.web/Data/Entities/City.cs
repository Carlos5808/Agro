using System.ComponentModel.DataAnnotations;

namespace Agro.web.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo  {0} es obligatorio")]
        [Display(Name = "Ciudad")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]

        public string? Name { get; set; }
    }
}
