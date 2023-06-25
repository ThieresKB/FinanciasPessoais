using Transacoes;

namespace Relatorios
{
    // Relatorio.cs
    public class Relatorio
    {
        public int Id { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public List<Transacao> Transacoes { get; set; }
    }
}
