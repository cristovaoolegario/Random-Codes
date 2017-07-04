using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Conta_6_2_
{
    class Contole
    {
        public static List<Conta> lista = new List<Conta>();

        public static void Ler()
        {
            string[] dados_arq;
            StreamReader leitura = new StreamReader("Banco.txt");
            while (!(leitura.EndOfStream))
            {
                string linha = leitura.ReadLine();
                if( linha != null)
                {
                    dados_arq = linha.Split(';');
                    string nome_titular = dados_arq[0];
                    int age = int.Parse(dados_arq[1]);
                    double saldo = double.Parse(dados_arq[2]);
                    int num = int.Parse(dados_arq[3]);
                    int tipo = int.Parse(dados_arq[4]);
                    DateTime abertura = DateTime.Parse(dados_arq[5]);

                    if (tipo == 1)
                    {
                        Poupanca a = new Poupanca(nome_titular, age, saldo, num, abertura);
                        lista.Add(a);
                    }
                    else
                    {
                        Investimento a = new Investimento(nome_titular, age, saldo, num, abertura);
                        lista.Add(a);
                    }
                }
                
            }
            leitura.Close();
        }
        public static void Gravar()
        {
            StreamWriter arq = new StreamWriter("Banco.txt");
            for (int i = 0; i < Conta.cont; i++)
            {
                if (lista[i].ativa)
                {
                    arq.WriteLine(lista[i].getNome() + ";" + lista[i].getAgencia() + ";" + lista[i].Saldo + ";" + lista[i].getNum() + ";" + lista[i].getTipo_Conta() + ";" + lista[i].Abertura.ToShortDateString());
                }
                
            }
            arq.Close();
        }
    }
}
