using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class Conta
    {
        public double saldo;
        public Agencia agencia;

        public void deposita(double valor)
        {
            saldo += valor;
        }
        public void saca(double valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
            }
        }
        public void imprimeExtrato()
        {
            Console.WriteLine("Saldo: " + saldo);
        }

        public void transfere(Conta destino, double valor)
        {
            if(valor <= saldo)
            {
                destino.saldo = valor;
            }
            else
            {
                Console.WriteLine("Saldo insulficiente!!");
            }
        }
    }
}
