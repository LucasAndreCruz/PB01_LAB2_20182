using System;
using System.Collections.Generic;
using System.Text;

namespace SGCV.ApplicationCore.Entity
{
    public class Animal
    {
        public int AnimalId { get; set; }

        public int Idade { get; set; }

        public string Sexo { get; set; }

        public string Nome { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public List<ConsultaAnimal> ConsultarAnimais { get; set; }

        public int EspecieId { get; set; }

        public Especie Especie { get; set; }
    }
}
