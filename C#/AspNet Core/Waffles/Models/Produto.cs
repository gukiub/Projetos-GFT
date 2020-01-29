namespace Waffles.Models
{
    public class Produto
    {
        public int id {get; set;}
        public string nome{get; set;}

        public Categoria categoria {get; set;}

        public override string ToString(){
            return "Id: " + this.id + "Nome: " + this.nome + "Categoria: [" + this.categoria.ToString() + "] " ;
        }

    }
}