using System;
using System.Collections.Generic;
using System.Text;

namespace SGCV.ApplicationCore.Entity
{
    public class Consulta
    {
        public int ConsultaId { get; set; }

        public DateTime Data { get; set; }

        public string Observacao { get; set; }

        public List<ConsultaAnimal> ConsultarAnimais { get; set; }

    }
}
