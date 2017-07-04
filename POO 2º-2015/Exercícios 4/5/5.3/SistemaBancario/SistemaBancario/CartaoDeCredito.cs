using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class CartaoDeCredito
    {
        private int numero;
        private string dataDeValidade;
        public Cliente cliente;
        //Incluindo faturas do cartão de credito
        Fatura[] fatura;
        public string DataDeValidade
        {
            get { return dataDeValidade; }
            set { dataDeValidade = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
    }
}
