using RafaelNascimento.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafaelNascimento.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UF uf = new UF();
            uf.Id = 1;
            uf.Sigla = "RJ";

            Cidade cidade = new Cidade();
            cidade.Id = 1;
            cidade.Nome = "Rio de Janeiro";
            cidade.UF = uf;

            Bairro bairro = new Bairro();
            bairro.Id = 1;
            bairro.Nome = "Botafogo";
            bairro.Cidade = cidade;

            Logradouro logradouro = new Logradouro();
            logradouro.Id = 1;
            logradouro.Nome = "Praia de Botafogo";
            logradouro.Numero = 1;
            logradouro.Tipo = TipoLogradouro.Rua;
            logradouro.Bairro = bairro;

            Endereco endereco = new Endereco();
            endereco.Id = 1;
            endereco.Tipo = TipoEndereco.Residencial;
            endereco.



        }
    }
}
