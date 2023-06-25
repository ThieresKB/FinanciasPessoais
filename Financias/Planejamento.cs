using Orcamentos;

namespace Planejamentos
{
    // Planejamento.cs
    public class Planejamento
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public List<Orcamento> Orcamentos { get; set; }
    }
}
