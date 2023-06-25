using INotificacoes;
namespace Contas
{
    // Conta.cs
    public class Conta
    {
        public int    Id   { get; private set; }
        public string Nome { get; private set; }
        private decimal _saldo;

        private List<INotificacao> _observadores;

        public Conta()
        {
            _observadores = new List<INotificacao>();
        }
        public decimal Saldo
        {
            get { return _saldo; }
            set {
                _saldo = value;
                NotificarObservadores();
            }
        }

        public void AdicionarObservador(INotificacao observador)
        {
            _observadores.Add(observador);
        }

        public void RemoverObservador(INotificacao observador)
        {
            _observadores.Remove(observador);
        }

        private void NotificarObservadores()
        {
            foreach (var observador in _observadores)
            {
                observador.Atualizar();
            }
        }
    }
}
