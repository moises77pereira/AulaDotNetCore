using System.Collections.Generic;

namespace AulaDotNetCore.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public ICollection<Pedido> Pedido { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
