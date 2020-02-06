using System.ComponentModel.DataAnnotations;

namespace Mercado.DTO
{
    public class ProdutoDTO
    {
        [Required]
        public int Id {get; set;}
        [Required(ErrorMessage="Nome do produto é obrigatório")]
        [StringLength(100, ErrorMessage="Nome do produto tem que ter menos de 100 caracteres")]
        [MinLength(2, ErrorMessage="O Nome do produto é muito curto")]
        public string Nome {get; set;}
        [Required(ErrorMessage="Categoria do produto é obrigatório")]
        public int CategoriaID {get; set;}
        [Required(ErrorMessage="Fornecedor do produto é obrigatório")]
        public int FornecedorID {get; set;}
        [Required(ErrorMessage="Preço de custo do produto é obrigatório")]
        public float PrecoDeCusto {get; set;}
        [Required(ErrorMessage="Preço de venda do produto é obrigatório")]
        public float PrecoDeVenda {get; set;}
        [Required(ErrorMessage="Medição do produto é obrigatória")]
        [Range(0,2, ErrorMessage="Medição inválida")]
        public int Medicao {get; set;}
    }
}