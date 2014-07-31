using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Model
{
    public abstract class Pessoa
    {
        public List<Telefone> Telefones { get; set; }
        public Endereco Endereco { get; set; }
        public String Email { get; set; }
    }
}
