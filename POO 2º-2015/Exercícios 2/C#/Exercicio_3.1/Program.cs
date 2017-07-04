using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3._1
{
    class Date5
    {
		public int[] meses = {31,28,31,30,31,30,31,31,30,31,30,31};
            
            
        private int dia, mes, ano;
        private void inicializacao(int dia, int mes, int ano) 
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }
        public Date5()
        {
            this.inicializacao(1, 1, 2000);
        }
        public Date5(int dia, int mes, int ano) 
        {
            this.inicializacao(dia, mes, ano);
        }
        public int getDia() { return dia; }
        public int getMes() { return mes; }
        public int getAno() { return ano; }
        public void setDia(int dia) { this.dia = dia; }
        public void setMes(int mes) { this.mes = mes; }
        public void setAno(int ano) { this.ano = ano; }
        public string switchmes(int mes)
        {
			
            string Extenso = "";
            switch (mes)
            {
                case 1:
                    Extenso = "Janeiro";
                    break;
                case 2:
                    Extenso = "Fevereiro";
                    break;
                case 3:
                    Extenso = "Março";
                    break;
                case 4:
                    Extenso = "Abril";
                    break;
                case 5:
                    Extenso = "Maio";
                    break;
                case 6:
                    Extenso = "Junho";
                    break;
                case 7:
                    Extenso = "Julho";
                    break;
                case 8:
                    Extenso = "Agosto";
                    break;
                case 9:
                    Extenso = "Setembro";
                    break;
                case 10:
                    Extenso = "Outubro";
                    break;
                case 11:
                    Extenso = "Novembro";
                    break;
                case 12:
                    Extenso = "Dezembro";
                    break;
                default:
                    Console.WriteLine("Mês Inválido");
                    break;
            }
            return Extenso;
        }
        public void extenso(int dia, int mes, int ano)
        {
            string[] Extenso = new string[3];
           
            Extenso[0] = Convert.ToString(dia);
            Extenso[1] = switchmes(mes);
            Extenso[2] = Convert.ToString(ano);

            Console.WriteLine("{0} de {1} de {2}", Extenso[0], Extenso[1], Extenso[2]);
        }
        public void proximoDia(int dia, int mes, int ano)
        {
            bool aux = true;

            if (ano > 1)
            {
                if (ano % 4 == 0)//se o resto da divisão do ano por 4 for 0, então o ano é bisexto.
                {
                    meses[1] = 29;
                    //	Console.WriteLine("O ano é bissexto");
                }
                else if (ano % 100 == 0 && ano % 400 == 0)
                {
                    meses[1] = 29;
                    //Console.WriteLine("O ano é bissexto");
                }
                if (mes <= 12 && dia <= meses[(mes-1)])
                {//testando se o dia e o mês são válidos.
                    if (dia + 1 > meses[(mes-1)])
                    {
                        dia = 1;
                        mes++;
                        if (mes > 12)
                        {
                            ano++;
                            mes = 1;
                        }
                    }
                    
                    
                }
                else
                {
                    Console.WriteLine("Data inválida");
                    aux = false;
                }
            }
            else
            {
                Console.WriteLine("Data inválida");
                aux = false;
            }
            if (aux == true)
                Console.WriteLine("O próximo dia será: {0}/{1}/{2}", dia, mes, ano);
            else
                Console.WriteLine("Não foi possível estabelecer o próximo dia devido a invalidez da data fornecida");
        }
        public void diffDias(int dia, int mes, int ano, int dia_2, int mes_2, int ano_2)
        {
			
			int anomai = 0, anomen = 0;
			int mesmai = 0, mesmen = 0;
			int i, soma = 0;
			
			if(ano > ano_2)
			{
				anomai = ano;
				anomen = ano_2;
			}
			else
			{
				anomai = ano_2;
				anomen = ano;
			}
			
			if(mes > mes_2)
			{
				mesmai = mes;
				mesmen = mes_2;
			}
			else
			{
				mesmai = mes_2;
				mesmen = mes;
			}
			
			for(i = (anomen + 1); i <= anomai; i++)
			{
				if(i % 4 != 0)
				{
					soma += 365;
				}
				else if(i % 100 != 0)
				{
					soma += 366;
				}
				else if(i % 400 != 0)
				{
					soma += 365;
				}
			}
			
			for(i = (mesmen + 1); i < mesmai; i++)
			{
				soma += meses[i - 1];
			}
			
			int somadia1 = 0, somadia2 = 0;
			somadia1 = meses[mes - 1] - dia + 1;
			for(i = 1; i < dia_2; i++)
			{
				int aux = 0;
				aux += i;
				somadia2 = aux;
			}
			soma += somadia1;
			soma += somadia2;
			
		
			Console.WriteLine(soma);

        }


        static void Main(string[] args)
        {
		   Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário");
           Date5 d;
           d = new Date5();
           Console.WriteLine("{0} {1} {2}", Convert.ToString(d.getDia()), Convert.ToString(d.getMes()), Convert.ToString(d.getAno()));
           Console.ReadKey();
         
			d.diffDias(1,1,2000,1,2,2000);
			Console.ReadKey();
        }
    }
}
