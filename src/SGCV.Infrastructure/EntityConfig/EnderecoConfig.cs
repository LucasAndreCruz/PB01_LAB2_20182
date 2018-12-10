using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCV.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCV.Infrastructure.EntityConfig
{
    public class EnderecoConfig : IEntityTypeConfiguration<Endereco>
    {

        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            #region Configurando a entidade Endereco com Fluent API

            builder.Property(e => e.Logradouro)
                .HasColumnType("varchar(200)");

            builder.Property(e => e.Bairro)
                .HasColumnType("varchar(200)");

            builder.Property(e => e.CEP)
                .HasColumnType("varchar(10)");

            builder.Property(e => e.Numero)
                .HasColumnType("varchar(10)");
            #endregion
        }


    }
}
