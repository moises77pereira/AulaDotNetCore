using AulaDotNetCore.Dominio.Contratos;
using AulaDotNetCore.Dominio.Entidades;
using AulaDotNetCore.Repositorio.Contexto;

namespace AulaDotNetCore.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(AulaDotNetContexto aulaDotNetContexto) : base(aulaDotNetContexto)
        {
        }
    }
}
