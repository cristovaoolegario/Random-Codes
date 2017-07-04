using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_6_2_
{
    class Poupanca : Conta
    {
        public static double taxa_juros = 0.5/100;
        
        public Poupanca()
        { }
        public Poupanca(String nome, int ag, double saldoInicial, DateTime r)// Contrutor
        {
            base.nome = nome;
            base.agencia = ag;
            base.saldo = saldoInicial;
            base.numConta = cont + 1;
            base.tipoConta = 1;
            cont++;

            abertura = r.Date;
        }
        public Poupanca(String nome, int ag, double saldoInicial, int num, DateTime a)// Contrutor para os dados que vem do aquivo
        {
            base.nome = nome;
            base.agencia = ag;
            base.saldo = saldoInicial;
            base.numConta = num;
            base.tipoConta = 1;
            cont++;

            abertura = a;
        }
        public double obterSaldo()
        {
            return base.saldo;
        }
    }
}
