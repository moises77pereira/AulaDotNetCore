namespace AulaDotNetCore.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (ProdutoId == 0)
                AdicionarCritica("Crítica - Não foi encontrado Id do Porduto");

            if (Quantidade == 0)
                AdicionarCritica("Crítica - CQuantidade não pode ser zero");
        }
    }
}
