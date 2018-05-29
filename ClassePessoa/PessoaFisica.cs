using System;
using System.Collections.Generic;
using System.Text;

namespace ClassePessoa
{
    public class PessoaFisica : Pessoa
    {
        private string cpf;

        public string Cpf { get; set; }

        public PessoaFisica(int Codigo, string Nome, string Cpf)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Cpf = Cpf;
        }
    }
}
