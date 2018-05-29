using System;
using System.Collections.Generic;
using System.Text;

namespace ClassePessoa
{
    public abstract class Pessoa
    {
        private int codigo;
        private string nome;

        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
}
