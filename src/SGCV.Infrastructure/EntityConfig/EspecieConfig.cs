using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCV.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCV.Infrastructure.EntityConfig
{
    public class EspecieConfig : IEntityTypeConfiguration<Especie>
    {


        public void Configure(EntityTypeBuilder<Especie> builder)
        {
            #region Configurando a entidade Especie com Fluent API

            builder.Property(c => c.Descricao)
                .HasColumnType("varchar(100)");

            #endregion
        }


    }
}
