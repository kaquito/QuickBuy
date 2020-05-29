using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagenValidacao { get; set; }
        private List<string> mensagemValidacao 
        {
            get { return _mensagenValidacao ?? (_mensagenValidacao = new List<string>()); }
        }
        protected void LimparMensagemValidacao()
        {
            mensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }
        public abstract void validete();
        protected bool EhValidado
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}
