// nome do programa: Program.cs
// programadores: Andrew de Oliveira Duchini, Cristóvão Olegário
// data:22/08/2015 
// descrição: Esse programa converte a temperatura em Celsius para Fahrenheit e Fahrenheit para Celsius.
//entrada: Recebe a opção do usuário e a temperatura.
//saída: Retorna a temperatura convertida.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3._9
{
    public class Conversao
    {
        float temperatura;

        public Conversao(string []args)
        {
            this.temperatura = float.Parse(args[0]);
        }
        public void CelsiusFahrenheit()
        {
			temperaturaFahrenheit = 1.8 * temperatura + 32;
        }
        public void FahrenheitCelsius()
        {
			temperaturaCelsius = (temperatura - 32) / 1.8;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int opcao =-1;

            Conversao C = new Conversao(args);

            Console.WriteLine("Programa de conversao de temperatura: ");

            do
            {
                try
                {
                    Console.WriteLine("Menu: ");
                    Console.WriteLine("Digite 1 para Converter de Celsius para Fahrenheit: ");
                    Console.WriteLine("Digite 1 para Converter de Fahrenheit para Celsius: ");
                    Console.WriteLine("Digite 3 para sair do programa: ");

                    Console.WriteLine();
                    Console.WriteLine("Digite sua opcao: ");
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1: C.FahrenheitCelsius();
                            break;
                        case 2: C.CelsiusFahrenheit();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite uma opcao valida!");
                }
            } while (opcao != 0);
        }
    }
}
