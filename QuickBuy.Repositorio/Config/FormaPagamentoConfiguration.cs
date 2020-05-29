using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);

            // Builder utiliza o padrão fluent
           
            builder
              .Property(f => f.Nome)
              .IsRequired()
              .HasMaxLength(50);

            builder
                .Property(f => f.Descriçao).
                IsRequired().
                HasMaxLength(100);


        }
    }
}
