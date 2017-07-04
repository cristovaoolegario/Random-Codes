// nome do programa: Program.cs
// programadores: Andrew de Oliveira Duchini, Cristóvão Olegário
// data:22/08/2015 
// descrição: Esse programa calcula o fatorial do número inteiro 
//recebido através de parâmetro passados na linha de comando.
//entrada: Recebe um número.
//saída: Retorna o fatorial do número fornecido.

using System;

namespace Exercicio3._7
{
    public class Fatorial
    {
        ulong numero;
        ulong resultado = 1;

        public Fatorial(string[]args)
        {
            try
            {
                this.numero = ulong.Parse(args[0]);
                calculaFatorial();
            }
            catch(FormatException)
            {
                Console.WriteLine("Por favor entre com um numero!");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Por favor entre com um numero positivo!");
            }
        }

        public void calculaFatorial()
        {
            for (uint i = 0; i < numero; i++)
            {
                resultado = resultado * (numero - i);
            }
            Console.WriteLine("Fatorial de {0}! = {1}", numero, resultado);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            Fatorial F = new Fatorial(args);
            Console.ReadKey();
        }
    }
}
