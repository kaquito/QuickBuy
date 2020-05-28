using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descriçao { get; set; }
        public decimal Preco { get; set; }

        public override void validete()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome não informado");

            if (Preco == 0)
                AdicionarCritica("Preço não Informado");
        }
    }
}

