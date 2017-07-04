// nome do programa: exercicio_3.3.cs
// programadores: Andrew de Oliveira Duchini, Cristóvão Olegário
// data:22/08/2015 
// descrição: Esse programa recebe através da linha de comando uma data composta por dia,
// mês e ano e chama um método denominado “quantosDias” que recebe como parâmetro esta data composta por dia,
// mês e ano e retorna o número de dias decorridos no ano até a data fornecida.
//entrada: Recebe uma data composta por dia, mês e ano.
//saída: Retorna o número de dias percorridos no ano até a data fornecida.

using System;

namespace ConsoleApplication3
{
    class Program
    {
        public static void quantosDias(int dia, int mes, int ano) 
        {
           
            int total_de_dias = 0;
            int[] meses = new int[12];
            meses[0] = 31;//janeiro
            meses[1] = 28;//fevereiro
            meses[2] = 31;//março
            meses[3] = 30;//abril
            meses[4] = 31;//maio
            meses[5] = 30;//junho
            meses[6] = 31;//julho
            meses[7] = 31;//agosto
            meses[8] = 30;//setembro
            meses[9] = 31;//outubro
            meses[10] = 30;//novembro
            meses[11] = 31;//dezembro

            if (ano > 1)
            {
					if (ano % 4 == 0)//se o resto da divisão do ano por 4 for 0, então o ano é bisexto.
                    {
                        meses[1] = 29;
					Console.WriteLine("O ano é bissexto");
                    }
                    else if (ano % 100 == 0 && ano% 400 == 0) 
                    {
                        meses[1] = 29;
					Console.WriteLine("O ano é bissexto");
                    }
				if (mes <= 12 && dia <= meses[mes - 1])
                {//testando se o dia e o mês são válidos.

			for (int i = 0; i < (mes - 1); i++)
            {
                total_de_dias += meses[i];
            }
            total_de_dias += dia;
            Console.WriteLine("Foram percorridos {0} dias desde o início do ano de {1} até a data {2}/{3}/{4}", total_de_dias, ano, dia, mes, ano);

                }

				else
				{
				Console.WriteLine("Data inválida");
				}
            }

            


        }
        static void Main(string[] args)
        {
            quantosDias(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToInt32(args[2]));
            Console.ReadKey();
        }
    }
}
