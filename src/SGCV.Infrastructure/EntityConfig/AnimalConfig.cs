using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGCV.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCV.Infrastructure.EntityConfig
{
    public class AnimalConfig : IEntityTypeConfiguration<Animal>
    {

        public void Configure(EntityTypeBuilder<Animal> builder)
        {

            #region Configurando a entidade Animal com Fluent API

            builder.Property(a => a.Sexo)
                .HasColumnType("varchar(5)");

            builder.Property(a => a.Nome)
                .HasColumnType("varchar(200)");

            #endregion
        }


    }
}
