using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Model
{
    public class PessoaJuridica : Pessoa
    {
        public String CNPJ { get; set; }
        public String Nome { get; set; }
        public String NomeFantasia { get; set; }

        public override string GetNome()
        {
            return this.NomeFantasia;
        }
    }
}
