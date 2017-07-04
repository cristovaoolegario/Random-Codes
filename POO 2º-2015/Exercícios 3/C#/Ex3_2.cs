using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_2
{
    class Program
    {
        static void Main(String[] args)
        {
			Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário");
			//TESTE
            ContaPoupanca a = new ContaPoupanca(500.0, 16);
            ContaCorrente b = new ContaCorrente(1000, 700);
            GeradorDeExtrato c = new GeradorDeExtrato();
            c.ImprimeExtratoBasico(a);
            c.ImprimeExtratoBasico(b);
            Console.ReadKey();
        }

        class Conta
        {
            public double Saldo { set; get ; }
            
        }
        class ContaPoupanca : Conta 
        {
            public int DiaDoAniversario { get ; set ; }
            public ContaPoupanca(double saldo, int dia)
            {
                Saldo = saldo;
                DiaDoAniversario = dia;
            }
        }
        class ContaCorrente : Conta 
        {
            public double Limite { get ; set; }
            public ContaCorrente(double saldo, double limite) 
            {
                Saldo = saldo;
                Limite = limite;
            }
        }
        class GeradorDeExtrato
        {
            public void ImprimeExtratoBasico(Conta c)
            {
                DateTime agora = DateTime.Now;
                string horario = String.Format(" {0: d/M/ yyyy HH:mm:ss}", agora);
                Console.WriteLine(" DATA : " + horario);
                Console.WriteLine(" SALDO : " + c.Saldo);
            }
        }
    }
}