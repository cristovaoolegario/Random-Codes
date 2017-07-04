// nome do programa: Program.cs
// programadores: Andrew de Oliveira Duchini, Cristóvão Olegário
// data:22/08/2015 
//descrição: Esse programa recebe através da linha de comando os votos de 15 eleitores para presidente.
//Sendo os candidatos: 19 – Machado de Assis, 21 – Guimarães Rosa, 33 – Cecília Meireles.
//Ao final da votação, o programa mostra o resultado final em número de votos e em porcentagem.
//entrada: Recebe os votos de 15 eleitores para presidente.
//saída: Retorna o resultado final em número de votos e em porcentagem.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int votoEleitor;
            int numVotos = 0;

            int votosMachadoDeAssis = 0;
            int votosCeciliaMeireles = 0;
            int votosGuimaraesRosa = 0;

            int votosMachadoDeAssisPorcentagem = 0;
            int votosCeciliaMeirelesPorcentagem = 0;
            int votosGuimaraesRosaPorcentagem = 0;

            for (int i = 0; i < args.Length; i++)
            {
                votoEleitor = int.Parse(args[i]);
                numVotos++;

                if (votoEleitor == 19)
                {
                    votosMachadoDeAssis++;
                }
                else if (votoEleitor == 21)
                {
                    votosGuimaraesRosa++;
                }
                else if (votoEleitor == 33)
                {
                    votosCeciliaMeireles++;
                }
                else
                {
                    Console.WriteLine("Voto invalido!");
                }
            }
            votosMachadoDeAssisPorcentagem = votosMachadoDeAssis / numVotos;
            votosGuimaraesRosaPorcentagem = votosGuimaraesRosa / numVotos;
            votosCeciliaMeirelesPorcentagem = votosCeciliaMeireles / numVotos;

            Console.WriteLine("Machado de Assis: {0}, {1}%", votosMachadoDeAssis, votosMachadoDeAssisPorcentagem);
            Console.WriteLine("GuimaraesRosa: {0}, {1}%", votosGuimaraesRosa, votosGuimaraesRosaPorcentagem);
            Console.WriteLine("CeciliaMeireles: {0}, {1}%", votosCeciliaMeireles, votosCeciliaMeirelesPorcentagem);

            Console.ReadKey();
        }
    }
}
