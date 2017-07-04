using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3._3
{
    class Quadrado
    {
        private int Lado;

        public Quadrado()
        {
            this.Lado = 1;
        }
        public Quadrado(int lado)
        {
            this.Lado = lado;
        }
        public int getLado()
        {
            return (this.Lado);
        }
        public void setLado(int lado)
        {
            this.Lado = lado;
        }
        static void Main(string[] args)
        {
			Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário");
            Quadrado n = new Quadrado();
            int lado;

            Console.WriteLine("Digite o novo lado do quadrado");
            lado = Convert.ToInt32(Console.ReadLine());
            n.setLado(lado);

            Console.WriteLine("O novo valor do lado é :" + n.getLado());
            Console.ReadKey();

        }
    }
}
