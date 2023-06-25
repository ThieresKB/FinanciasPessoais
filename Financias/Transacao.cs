using Contas;

namespace Transacoes
{
    // Transacao.cs
    public class Transacao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Conta Remetente { get; set; }
        public Conta Destinatário { get; set; }
    }

}
