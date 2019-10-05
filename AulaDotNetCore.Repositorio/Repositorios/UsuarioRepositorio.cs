using AulaDotNetCore.Dominio.Contratos;
using AulaDotNetCore.Dominio.Entidades;
using AulaDotNetCore.Repositorio.Contexto;
using System.Linq;

namespace AulaDotNetCore.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(AulaDotNetContexto aulaDotNetContexto) : base(aulaDotNetContexto)
        {
        }

        public Usuario Obter(string email, string senha)
        {
            return AulaDotNetContexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return AulaDotNetContexto.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }
}
