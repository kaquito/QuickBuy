namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void validete()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Não foi encontrado o produto");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não foi informada");
        }
    }
}
