using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.Entidades;

namespace QuickBuy.Repositorio.Config
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            // Builder utiliza o padrão fluent
            builder
                .Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(50);

            builder
              .Property(p => p.Descriçao)
              .IsRequired()
              .HasMaxLength(400);

            builder
              .Property(p => p.Preco)
              .IsRequired();
              
        }
    }
}
