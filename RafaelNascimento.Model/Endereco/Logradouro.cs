using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Model
{
    public class Logradouro
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public int Numero { get; set; }
        public TipoLogradouro Tipo { get; set; }
        public Bairro Bairro { get; set; }


        
    }
}
