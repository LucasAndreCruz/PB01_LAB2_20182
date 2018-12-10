using System;
using System.Collections.Generic;
using System.Text;

namespace SGCV.ApplicationCore.Entity
{
    public class Endereco
    {

        public int EnderecoId { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string CEP { get; set; }

        public string Numero { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
