using AulaDotNetCore.Dominio.Entidades.ObjetoDeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AulaDotNetCore.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(p => p.Id);
            //Builder utiliza o padrão Fluent
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
