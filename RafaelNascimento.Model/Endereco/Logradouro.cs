using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Model
{
    public class Logradouro
    {
        public String Logradouro { get; set; }
        public TipoLogradouro Tipo { get; set; }
        public Bairro Bairro { get; set; }
    }
}
