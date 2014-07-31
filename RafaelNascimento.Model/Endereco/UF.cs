using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.Model
{
    public class UF
    {
        public int Id { get; set; }
        public String Sigla { get; set; }
        //public String Nome { get; set; }

        public override string ToString()
        {
            return this.Sigla;
        }
    }
}
