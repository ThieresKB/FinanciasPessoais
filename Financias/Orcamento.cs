using Categorias;

namespace Orcamentos
{
    // Orcamento.cs
    public class Orcamento
    {
        public int Id { get; set; }
        public decimal ValorTotal { get; set; }
        public List<Categoria> Categorias { get; set; }
    }
}
