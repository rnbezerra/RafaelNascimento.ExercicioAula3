using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Model
{
    public class Cidade
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public UF UF { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(this.Nome);
            builder.Append(this.UF.ToString());
            return ;
        }
    }
}
