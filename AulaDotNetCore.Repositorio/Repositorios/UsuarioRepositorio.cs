using AulaDotNetCore.Dominio.Contratos;
using AulaDotNetCore.Dominio.Entidades;
using AulaDotNetCore.Repositorio.Contexto;

namespace AulaDotNetCore.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(AulaDotNetContexto aulaDotNetContexto) : base(aulaDotNetContexto)
        {
        }
    }
}
