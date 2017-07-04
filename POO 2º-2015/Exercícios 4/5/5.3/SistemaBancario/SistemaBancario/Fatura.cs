using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class Fatura
    {
        public double total;

        // Adiciona o valor ao total da fatura
        public void adiciona(double valor)
        {
            total += valor;
        }

        // Calcula multa de 2% sobre o total da fatura
        public double calculaMulta() 
        { 
            double res;
            res = 0.02 * total;

            return res;
        }
        // Imprime o total da fatura
        public void imprimeDados() 
        {
            Console.WriteLine("Total da Fatura: "+total);
        }

    }
}
