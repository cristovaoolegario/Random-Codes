using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_6_2_
{
    class Investimento : Conta
    {
        public static double rendimento = 0.65 / 100;
        public static double imposto = 0.15;

        public Investimento(String nome, int ag, double saldoInicial, DateTime r)// Contrutor
        {
            base.nome = nome;
            agencia = ag;
            saldo = saldoInicial;
            numConta = cont + 1;
            tipoConta = 2;
            cont++;

            abertura = r.Date;
        }
        public Investimento(String nome, int ag, double saldoInicial, int num, DateTime a)// Contrutor para os dados que vem do aquivo
        {
            base.nome = nome;
            base.agencia = ag;
            base.saldo = saldoInicial;
            base.numConta = num;
            base.tipoConta = 2;
            cont++;

            abertura = a;
        }
        public double obterSaldo()
        {
            return base.saldo;
        }        
    }
}
