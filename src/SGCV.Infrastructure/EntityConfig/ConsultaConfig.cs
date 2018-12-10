using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCV.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCV.Infrastructure.EntityConfig
{
    public class ConsultaConfig : IEntityTypeConfiguration<Consulta>
    {

        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            #region Configurando a entidade Consulta com Fluent API

            builder.Property(c => c.Observacao)
                .HasColumnType("varchar(100)");

            #endregion

        }



    }
}
