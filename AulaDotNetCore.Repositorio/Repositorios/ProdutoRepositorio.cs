using AulaDotNetCore.Dominio.Contratos;
using AulaDotNetCore.Dominio.Entidades;
using AulaDotNetCore.Repositorio.Contexto;

namespace AulaDotNetCore.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(AulaDotNetContexto aulaDotNetContexto) : base(aulaDotNetContexto)
        {
        }
    }
}
