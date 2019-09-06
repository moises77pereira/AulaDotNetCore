using AulaDotNetCore.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AulaDotNetCore.Repositorio.Config
{
    public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(Ip => Ip.Id);

            builder
                .Property(Ip => Ip.ProdutoId)
                .IsRequired();

            builder
                .Property(Ip => Ip.Quantidade)
                .IsRequired();
        }
    }
}
