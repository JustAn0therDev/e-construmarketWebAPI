namespace Entities
{
    /// <summary>
    /// Classe que representa um produto
    /// </summary>
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Marca Marca { get; set; }
    }
}
