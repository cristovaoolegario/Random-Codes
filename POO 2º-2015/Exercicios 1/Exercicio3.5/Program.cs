// nome do programa: Program.cs
// programadores: Andrew de Oliveira Duchini, Cristóvão Olegário
// data:22/08/2015 
// descrição: receba n números inteiros através da linha de comando, armazena em um vetor e
// que chama um método que receba estes números inteiros (armazenados no vetor), colocando-os na ordem crescente de valores.
//entrada: n números inteiros
//saída: Exibi o números ordenados na ordem crescente de valores.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdNumeros;

            qtdNumeros = int.Parse(args[0]);

            int[] vet = new int[qtdNumeros];
			
			for(int i = 0; i < vet.Legth - 1; i++)
			{
				vet[i] = args[i + 1];
			}

            vet = transformaVetor(vet);

            Console.WriteLine("Vetor: ");

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(" "+ vet[i]);
            }
            Console.ReadKey();
        }
        public static int[] transformaVetor(int[]vet)
        {
            int aux;
            int aux2;

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vet.Length; i++)
            {
                aux = vet[i];

                for (int j = i + 1; j < vet.Length; j++)
                {
                    if (aux > vet[j])
                    {
                        aux2 = aux;
                        aux = vet[j];
                        vet[i] = aux;
                        vet[j] = aux2;
                    }
                }
                vet[i] = aux;
            }
            return vet;
        }
    }
}
