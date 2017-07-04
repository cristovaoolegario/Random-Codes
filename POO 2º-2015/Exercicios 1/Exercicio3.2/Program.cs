// nome do programa: Program.cs
// programadores: Andrew de Oliveira Duchini, Cristóvão Olegário
// data:22/08/2015 
// descrição: Este programa recebe n números inteiros através da linha de comando,
// armazena em um vetor, denominado "vet", e retorna o maior, menor e a média 
// dos números recebidos. 
// entrada: n números interios
// saída:  o maior, menor e a média de todos os números recebidos.

using System;

namespace Exercicio3._2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário");
            int n = int.Parse(args[0]);
            int menor = int.MaxValue;
            int maior = 0;
            int total = 0;

            float media;

            int[] vet = new int[n];

            for (int i = 0; i < vet.Length - 1; i++)
            {
                vet[i] = int.Parse(args[i + 1]);
                total = total + vet[i];

                if (menor > vet[i])
                {
                    menor = vet[i];
                }
                if (maior < vet[i])
                {
                    maior = vet[i];
                }
            }
            media = total / vet.Length;

            Console.WriteLine("Maior: {0}",maior);
            Console.WriteLine("Menor: {0}", menor);
            Console.WriteLine("Media: {0}", media);

            Console.ReadKey();
        }
    }
}
