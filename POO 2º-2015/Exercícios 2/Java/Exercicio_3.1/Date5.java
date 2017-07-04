import java.io.IOException;
import java.io.*;
import java.util.Scanner;

class Date5
    {
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
        public String switchmes(int mes)
        {
            String Extenso = " ";
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
            String[] Extenso = new String[3];
           
            Extenso[0] = Convert.ToString(dia);
            Extenso[1] = switchmes(mes);
            Extenso[2] = Convert.ToString(ano);

             System.out.println("{0} de {1} de {2}", Extenso[0], Extenso[1], Extenso[2]);
        }
        public void proximoDia(int dia, int mes, int ano)
        {
            int[] meses = new int[12];
            bool aux = true;
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
                }
                else if (ano % 100 == 0 && ano % 400 == 0)
                {
                    meses[1] = 29;                    
                }
                if (mes <= 12 && dia <= meses[(mes-1)])
                {
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
                    System.out.println("Data inválida");
                    aux = false;
                }
            }
            else
            {
                System.out.println("Data inválida");
                aux = false;
            }
            if (aux == true)
                System.out.println("O próximo dia será: {0}/{1}/{2}", dia, mes, ano);
            else
                System.out.println("Não foi possível estabelecer o próximo dia devido a invalidez da data fornecida");
        }
        public void diffDias(int dia, int mes, int ano, int dia_2, int mes_2, int ano_2)
        {

        }


        static void Main(string[] args)
        {
           Date5 d;
           d = new Date5();
           
           
          
        }
    }