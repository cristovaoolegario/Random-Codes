using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_1
{
    class Program
    {
        class Funcionario_Generico
        {
            protected string nome;
            protected int cpf;
            protected double salario;
        }
        class Gerente : Funcionario_Generico
        {
            Controle_de_Ponto c;

            public Gerente(string nome, int cpf, double salario)
            {
                this.nome = nome;
                this.cpf = cpf;
                this.salario = salario;
            }
            public void horas()
            {
                c = new Controle_de_Ponto();
            }
        }
        class Telefonista : Funcionario_Generico
        {
            Controle_de_Ponto c;
            public Telefonista(string nome, int cpf, double salario)
            {
                this.nome = nome;
                this.cpf = cpf;
                this.salario = salario;
            }
            public void horas()
            {
                c = new Controle_de_Ponto();
            }
        }
        class Controle_de_Ponto
        {
            int[] hora_de_entrada = new int[2];
            int[] hora_de_saida = new int[2];

            public Controle_de_Ponto()
            {
                string hora;
                Console.WriteLine("digite o horario de entrada, separado por ':'");
                hora = Console.ReadLine();
                string[] hora_de_entrada = (hora.Split(':'));
                Console.WriteLine("digite o horario de saida, separado por ':'");
                hora = Console.ReadLine();
                string[] hora_de_saida = (hora.Split(':'));

            }
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário");
            Telefonista t = new Telefonista("Joana", 1233432, 1000);
            Gerente g = new Gerente("Geraldo", 5432345, 2000);

            g.horas();
            t.horas();
            
        }
    }
}