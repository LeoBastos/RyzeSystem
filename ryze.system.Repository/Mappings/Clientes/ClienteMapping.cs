using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ryze.system.Domain.Entities.Clientes;
using ryzen.system.Common.Enums;

namespace ryze.system.Repository.Mappings.Clientes
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable(nameof(Cliente));

            builder.HasKey(p => p.Id);

            builder.Property(p => p.NomeFantasia)
                .IsRequired();

            builder.Property(p => p.Telefone)
                .IsRequired();

            builder.Property(p => p.Email)
                .IsRequired();

            builder.Property(p => p.Cnpj)
                .IsRequired();

            builder.Property(p => p.IsAtivo)
                .IsRequired();

            builder.Property(p => p.Cep)
                .IsRequired();

            builder.Property(p => p.Logradouro)
                .IsRequired();

            builder.Property(p => p.Numero)
                .IsRequired();

            builder.Property(p => p.Complemento);

            builder.Property(p => p.Bairro)
                .IsRequired();

            builder.Property(p => p.Cidade)
                .IsRequired();

            builder.Property(p => p.Uf)
                .HasConversion(new EnumToStringConverter<EUf>())
               .IsRequired();
        }
    }
}
