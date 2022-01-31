namespace ProdutosCrud.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? ProdutoNome { get; set; }
        public decimal Preco { get; set; }  
        public int Estoque { get; set; }
        public string? Imagem { get; set; }
    }
}
