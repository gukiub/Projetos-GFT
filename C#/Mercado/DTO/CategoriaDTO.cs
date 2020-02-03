using System.ComponentModel.DataAnnotations;

namespace Mercado.DTO
{
    public class CategoriaDTO
    {
        [Required]
        public int Id {get; set;}
        [Required(ErrorMessage="• Nome de categoria é orbital")]
        [StringLength(100, ErrorMessage="• Nome de categoria muito grande, tente um nome menor.")]
        [MinLength(2, ErrorMessage="• Nome de categoria muito pequeno, tente um nome maior.")]
        public string Nome {get; set;}
    }
}