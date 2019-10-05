using AulaDotNetCore.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AulaDotNetCore.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            //Builder utiliza o padrão Fluent
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(p => p.Preco)
                .IsRequired()
                .HasColumnType("decimal(19,4)");

            builder
                .Property(p => p.NomeArquivo)
                .HasMaxLength(40);
        }
    }
}
