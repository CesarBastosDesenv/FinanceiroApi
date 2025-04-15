using Financeiro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Financeiro.Infra.Data.Mappings;

public class AtivoMap : IEntityTypeConfiguration<Ativo>
{
    public void Configure(EntityTypeBuilder<Ativo> builder)
    {
         builder.ToTable("Ativos");

        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.NomeAtivo)
        .HasColumnType("varchar(50)");

        builder.Property(x => x.NomeCompleto)
        .HasColumnType("varchar(50)");
    }
}
