using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ryze.system.Domain.Entities.Pedidos;

namespace ryze.system.Repository.Mappings.Pedidos
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable(nameof(Pedido));

            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataPedido)
                .IsRequired();

            builder.Property(p => p.Observacao);

            builder.Property(p => p.Status);
                       
            builder.HasOne(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);           
        }
    }
}
