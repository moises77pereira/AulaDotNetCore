using AulaDotNetCore.Dominio.Entidades;
using AulaDotNetCore.Dominio.Entidades.ObjetoDeValor;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace AulaDotNetCore.Repositorio.Contexto
{
    public class AulaDotNetContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public AulaDotNetContexto(DbContextOptions options) : base(options)
        {
        }
    }
}
