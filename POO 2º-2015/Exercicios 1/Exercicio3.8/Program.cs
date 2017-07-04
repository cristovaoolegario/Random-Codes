// nome do programa: Program.cs
// programadores: Andrew de Oliveira Duchini, Cristóvão Olegário
// data:22/08/2015 
// descrição: Esse programa simula um conta de banco.
//entrada: Recebe uma das ordens do usuário, explicitas no menu.
//saída: Executa uma das ordens do usuário, mostradas no menu.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3._8
{
    public class Conta
    {
        float saldo;

        public Conta()
        {
            this.saldo = 0;
        }
        
        public void deposita(float valor)
        {
            saldo = saldo + valor;
            Console.WriteLine();
            imprimirSaldo();
        }
        public void retirar(float valor)
        {
            if(saldo < valor)
            {
                Console.WriteLine("Seu saldo esta negativo! ");
                Console.WriteLine("A operacao nao pode ser executada!");
                Console.WriteLine();
                imprimirSaldo();
            }
            else
            {
                saldo = saldo - valor;
                imprimirSaldo();
            }
        }
        public void imprimirSaldo()
        {
            Console.WriteLine("Seu saldo: {0} ", saldo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1;
            float valor;
            Conta C = new Conta();
            Console.WriteLine("Seja bem vindo ao sistema de cantas bancarias!");
            Console.WriteLine();

            do
            {
                Console.WriteLine();
                Console.WriteLine("Menu: ");
                Console.WriteLine("Digite 1 para depositar dinheiro: ");
                Console.WriteLine("Digite 2 para fazer retirada de dinheiro: ");
                Console.WriteLine("Digite 3 para imprimir o saldo bancario: ");
                Console.WriteLine("Digite 0 para sair do programa: ");
                Console.WriteLine();

                try
                {
                    Console.WriteLine("Digite a sua opcao: ");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1: Console.WriteLine("Digite o valor a ser depositado: ");
                            valor = float.Parse(Console.ReadLine());
                            C.deposita(valor);
                            break;
                        case 2: Console.WriteLine("Digite o valor a ser retirado: ");
                            valor = float.Parse(Console.ReadLine());
                            C.retirar(valor);
                            break;
                        case 3: C.imprimirSaldo();
                            break;
                    }
                }
                catch(FormatException)    
                {
                    Console.WriteLine("Opcao invalida!");
                    Console.WriteLine();
                    Console.WriteLine("Digite sua opcao novamente: ");
                }

            } while (opcao != 0);
        }
    }
}
