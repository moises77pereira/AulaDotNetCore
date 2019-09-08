﻿using AulaDotNetCore.Dominio.Entidades;
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

            modelBuilder.Entity<FormaPagamento>().HasData(new FormaPagamento() { Id = 1, Nome = "Boleto", Descricao = "Forma de Pagamento Boleto" },
                                                          new FormaPagamento() { Id = 2, Nome = "Cartão de Crédito", Descricao = "Forma de Pagamento Catão de Crédito" },
                                                          new FormaPagamento() { Id = 3, Nome = "Depósito", Descricao = "Forma de Pagamento Depósito" });

            base.OnModelCreating(modelBuilder); 
        }
    }
}
