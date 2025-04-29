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
  public  class CategoriaConfigurations : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).HasMaxLength(100).IsRequired();
            builder.Property(c => c.ImagemUrl).HasMaxLength(250).IsRequired();

            builder.HasData(
                new Categoria(1, "Bebidas", "https://www.linkparaimagem.com.br/bebidas"),
                new Categoria(2, "Lanches", "https://www.linkparaimagem.com.br/lanches"),
                new Categoria(3, "Sobremesas", "https://www.linkparaimagem.com.br/sobremesas")
            );

        }
    }
}
