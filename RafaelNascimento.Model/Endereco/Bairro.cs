using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Model
{
    public class Bairro
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public Cidade Cidade { get; set; }
    }
}
