using System.ComponentModel.DataAnnotations;

namespace Mercado.DTO
{
    public class FornecedorDTO
    {
        [Required]
        public int Id {get; set;}

        [Required(ErrorMessage="• Nome de Fornecedor é orbital")]
        [StringLength(100, ErrorMessage="• Nome de Fornecedor muito grande, tente um nome menor.")]
        [MinLength(2, ErrorMessage="• Nome de Fornecedor muito pequeno, tente um nome maior.")]
        public string Nome {get; set;}
        [Required(ErrorMessage="• E-mail de fornecedor é obrigatório")]
        [EmailAddress(ErrorMessage="• E-mail invalido")]
        public string Email {get; set;}
        [Required(ErrorMessage="• Telefone de fornecedor é obrigatório")]
        [Phone(ErrorMessage="• Número de telefone inválido")]
        public string Telefone {get; set;}
    }
}