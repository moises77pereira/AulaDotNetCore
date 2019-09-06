using AulaDotNetCore.Dominio.Entidades;
using AulaDotNetCore.Dominio.Entidades.ObjetoDeValor;
using AulaDotNetCore.Repositorio.Config;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// Classes de mapeamento aqui
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            base.OnModelCreating(modelBuilder); 
        }
    }
}
