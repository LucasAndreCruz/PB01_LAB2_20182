using System;
using System.Collections.Generic;
using System.Text;

namespace SGCV.ApplicationCore.Entity
{
   public class ConsultaAnimal
    {
        public int Id { get; set; }

        public int AnimalId { get; set; }

        public Animal Animal { get; set; }

        public int ConsultaId { get; set; }

        public Consulta Consulta { get; set; }

    }
}
