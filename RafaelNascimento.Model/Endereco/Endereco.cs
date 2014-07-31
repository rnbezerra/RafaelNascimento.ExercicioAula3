using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public TipoEndereco Tipo { get; set; }
        public Logradouro Logradouro { get; set; }

        public Endereco()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
