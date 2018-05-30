using System;
using System.Collections.Generic;
using System.Text;

namespace ClassePessoa
{
    public class PessoaFisica : Pessoa
    {
        private string cpf;

        public string Cpf { get { return cpf; } set { cpf = value; } }

        public PessoaFisica(int codigo, string nome, string cpf)
        {
            Codigo = codigo;
            Nome = nome;
            Cpf = cpf;
        }
    }
}
