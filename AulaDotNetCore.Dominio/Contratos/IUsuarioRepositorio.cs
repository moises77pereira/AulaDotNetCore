using AulaDotNetCore.Dominio.Entidades;

namespace AulaDotNetCore.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);
    }
}
