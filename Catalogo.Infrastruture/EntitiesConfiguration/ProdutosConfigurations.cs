using Catalogo.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Infrastruture.EntitiesConfiguration
{
  public  class ProdutosConfigurations : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p=> p.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Descricao).HasMaxLength(250).IsRequired();
            builder.Property(p => p.ImagemUrl).HasMaxLength(250).IsRequired();
            builder.Property(p => p.Preco).HasPrecision(18, 2).IsRequired();
            builder.Property(p => p.Estoque).IsRequired();
            builder.Property(p => p.DataCadastro).IsRequired();

            builder.HasOne<Categoria>()
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
