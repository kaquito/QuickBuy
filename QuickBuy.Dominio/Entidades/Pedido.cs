using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoID { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        /// <summary>
        /// O pedido deve ter pelo menos 1 Itens do Pedido 
        /// ou muitos Itens do Pedido
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }
    }
}
