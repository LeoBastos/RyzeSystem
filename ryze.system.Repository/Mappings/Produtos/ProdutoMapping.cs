using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ryze.system.Common.Enums;
using ryze.system.Domain.Entities.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ryze.system.Repository.Mappings.Produtos
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable(nameof(Produto));

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasPrecision(10, 2)
                .IsRequired();

            builder.Property(p => p.Estoque)
                .IsRequired();

            builder.Property(p => p.Imagem);                

            builder.Property(p => p.TipoProduto)
               .HasConversion(new EnumToStringConverter<TipoProduto>())
               .IsRequired();

            builder.Property(p => p.IsAtivo)
               .IsRequired();
        }
    }
}
