// nome do programa: Program.cs
// programadores: Andrew de Oliveira Duchini, Cristóvão Olegário
// data:22/08/2015 
// descrição: Esse programa implementa uma calculadora, com as quatro operações básicas com números reais.
//entrada: Recebe um número, uma operação e um segundo número.
//saída: Retorna o resultado da operação.

using System;

namespace Exercicio3._6
{
    public class Operacoes
    {
        char operador;

        float parcela1;
        float parcela2;
        float resultado;

        public Operacoes(string[]vet)
        {
            try
            {
                this.parcela1 = float.Parse(vet[0]);
                this.parcela2 = float.Parse(vet[1]);
                this.operador = char.Parse(vet[2]);
                calcula();
            }
            catch (FormatException)
            {
                Console.WriteLine("Operador digitado de forma errada!");
            }
        }

        public void soma()
        {
            resultado = parcela1 + parcela2;
            Console.WriteLine("Resultado: " + resultado);
        }
        public void subtracao()
        {
            resultado = parcela1 - parcela2;
            Console.WriteLine("Resultado: " + resultado);
        }
        public void multiplicao()
        {
            resultado = parcela1 * parcela2;
            Console.WriteLine("Resultado: " + resultado);
        }
        public void divisao()
        {
            if (parcela2 != 0)
            {
                resultado = parcela1 / parcela2;
                Console.WriteLine("Resultado: " + resultado);
            }
            else
            {
                Console.WriteLine("Erro divisao por 0");
            }

        }
        public void calcula()
        {
            switch (operador)
            {
                case '+': soma();
                    break;
                case '-': subtracao();
                    break;
                case '*': multiplicao();
                    break;
                case '/': divisao();
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Operacoes O = new Operacoes(args);

            Console.ReadKey();
        }
    }
}
