using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
// NOME DO PROGRAMA: ContaDePoupança 
// 
// PROGRAMADORES: 
// Pedro Lucas Duarte Faria(536589)  
// Samara Luiza da Silva(536592) 
// Andrew de Oliveira Duchini (537983)
// Cristóvão Olegário de Castro (536584)

// DATA: 29/10/2015 
// DESCRIÇÃO: O programa implementa uma class com métodos de instacia e métodos estaticos
// Utiliza um programa teste para testar sua funcionalidade
namespace ConsoleApplication1
{
    class Program
    {
        class ContaDePoupança
        { 
            // Atributos
            static double taxadeJurosAnual = 0.04;
            private double saldoPoupanca;
            //Construtores
            public ContaDePoupança() {}
            public ContaDePoupança (double taxa, double saldo)
            {
                taxadeJurosAnual = taxa;
                saldoPoupanca = saldo;
            }
            // Propiedades
            public double SaldoPoupaca
            {
                get { return saldoPoupanca;}
                set { saldoPoupanca = value;}
            }
            public double Taxa
            {
                get { return taxadeJurosAnual; }
                set { taxadeJurosAnual = value; }
            }
            // Metodos
            public void CalcularJuroMensal ()
            {
                saldoPoupanca = saldoPoupanca + ((saldoPoupanca * taxadeJurosAnual) / 12.0);
                
            }
            public static void AlterarTaxaDeJuros(double novo)
            {
                taxadeJurosAnual = novo;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("\tProgramadores: ");
            Console.WriteLine("\tAndrew de Oliveira Duchini (537983)");
            Console.WriteLine("\tCristóvão Olegário de Castro (536584)");
            Console.WriteLine("\tPedro Lucas Duarte Faria(536589)");
            Console.WriteLine("\tSamara Luiza da Silva(536592)");
            ContaDePoupança poudador1 = new ContaDePoupança(0.04, 2000);
            ContaDePoupança poudador2 = new ContaDePoupança(0.04, 3000);
            poudador1.CalcularJuroMensal();
            poudador2.CalcularJuroMensal();
            Console.WriteLine("Taxa de 4%");
            Console.WriteLine("Novo saldo do poupador 1: " + poudador1.SaldoPoupaca);
            Console.WriteLine("Novo saldo do poupador 2: " + poudador2.SaldoPoupaca);
            ContaDePoupança.AlterarTaxaDeJuros(0.05);
            poudador1.CalcularJuroMensal();
            poudador2.CalcularJuroMensal();
            Console.WriteLine("Taxa de 5%");
            Console.WriteLine("Novo saldo do poupador 1: " + poudador1.SaldoPoupaca);
            Console.WriteLine("Novo saldo do poupador 2: " + poudador2.SaldoPoupaca);
            Console.ReadKey();
            
        }
    }
}
