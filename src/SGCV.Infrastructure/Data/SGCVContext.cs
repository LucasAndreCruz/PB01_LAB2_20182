using Microsoft.EntityFrameworkCore;
using SGCV.ApplicationCore.Entity;
using SGCV.Infrastructure.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGCV.Infrastructure.Data
{
    public class SGCVContext : DbContext
    {

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<ConsultaAnimal> ConsutasAnimais { get; set; }
        public DbSet<Especie> Especies { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BdSGCV;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConsultaAnimal>().ToTable("MarcarConsulta");


            modelBuilder.ApplyConfiguration(new ClienteConfig());

            modelBuilder.ApplyConfiguration(new AnimalConfig());

            modelBuilder.ApplyConfiguration(new ConsultaConfig());

            modelBuilder.ApplyConfiguration(new EspecieConfig());

            modelBuilder.ApplyConfiguration(new EnderecoConfig());

           
          #region Propagação de dados das entidades

            modelBuilder.Entity<Cliente>()
                .HasData(
                
                new Cliente { ClienteId = 1, Nome = "Lucas André", Email = "lucasandre@gmail.com" }
                
                );

            modelBuilder.Entity<Animal>()
                .HasData(
                
                new Animal { AnimalId = 1, Idade = 2, Sexo = "Macho", Nome = "Chulin", ClienteId = 1, EspecieId = 1}
                
                );

            modelBuilder.Entity<Consulta>()
                .HasData(
                
                new Consulta { ConsultaId = 1, Observacao = "Consulta de Rotina" }
                
                );

            modelBuilder.Entity<ConsultaAnimal>()
                .HasData(
                
                    new ConsultaAnimal { Id = 1, ConsultaId = 1, AnimalId = 1}

                
                );

            modelBuilder.Entity<Especie>()
                .HasData(
                
                new Especie { EspecieId = 1, Descricao = "PitBull"}
                
                );

            modelBuilder.Entity<Endereco>()
                .HasData(
                
                new Endereco { EnderecoId = 1, Logradouro = "Rua cinco, Quandra 04",
                               Bairro = "CPA III", CEP = "78058-326", Numero = "180",
                               ClienteId = 1}
                
                );



            #endregion

            


        }


    }
}
