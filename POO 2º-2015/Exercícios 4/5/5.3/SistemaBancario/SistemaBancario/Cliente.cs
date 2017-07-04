using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class Cliente
    {
        private string nome;
        private int codigo;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
