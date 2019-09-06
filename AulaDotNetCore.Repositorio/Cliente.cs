using AulaDotNetCore.Dominio.Entidades;
using AulaDotNetCore.Repositorio.Repositorios;

namespace AulaDotNetCore.Repositorio
{
    public class Cliente
    {
        public Cliente()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var usuario = new Usuario();
            usuarioRepositorio.Adicionar(usuario);
        }
    }
}
