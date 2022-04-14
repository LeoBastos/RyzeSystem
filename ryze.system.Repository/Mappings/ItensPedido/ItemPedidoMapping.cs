using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ryze.system.Domain.Entities.ItensPedido;

namespace ryze.system.Repository.Mappings.ItensPedido
{
    public class ItemPedidoMapping : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable(nameof(ItemPedido));

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Quantidade)
                .HasDefaultValue(1)
                .IsRequired();

            builder.Property(p => p.Valor)
                .HasPrecision(10, 2)
                .IsRequired();

            builder.Property(p => p.Desconto)
                .HasPrecision(10, 2);

            builder.HasOne(c => c.Pedido)
                .WithMany()
                .HasForeignKey(c => c.PedidoId);

            builder.HasMany(p => p.Produtos)
                .WithOne()
                .HasForeignKey(p => p.Id);
        }

    }
}
