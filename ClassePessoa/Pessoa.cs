using System;
using System.Collections.Generic;
using System.Text;

namespace ClassePessoa
{
    public abstract class Pessoa
    {
        private int codigo;
        private string nome;

        public int Codigo { get {return codigo; } set { codigo = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
    }
}
