using System;
using System.Collections.Generic;
using System.Text;

namespace SGCV.ApplicationCore.Entity
{
    public class Especie
    {

        public int EspecieId { get; set; }

        public string Descricao { get; set; }

        public List<Animal> Animals { get; set; }

    }
}
