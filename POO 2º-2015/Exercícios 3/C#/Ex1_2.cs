using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_2
{
    class Program
    {
        public class PFisica : Contribuinte
        {
            protected string cpf;
            protected double salario;

            public PFisica(string n, string end, double sal, String c)
            {
                this.nome = n;
                this.endereco = end;
                cpf = c;
                salario = sal;

                Console.WriteLine(nome + " imposto de " + calcImposto());
            }
            public override double calcImposto()
            {
                double imposto = 0;
                if (salario > 0 && salario <= 1400)
                {

                }
                else if (salario > 1400 && salario <= 2100)
                {
                    imposto = salario * 0.1;//10% de imposto
                }
                else if (salario > 2100 && salario <= 2800)
                {
                    imposto = salario * 0.15;//15% de imposto
                }
                else if (salario > 2800 && salario <= 3600)
                {
                    imposto = salario * 0.25;//20% de imposto
                }
                else if (salario > 3600)
                {
                    imposto = salario * 0.30;//30% de imposto
                }
                else
                {
                    Console.WriteLine("salario inválido");
                }

                return (imposto);
            }
        }
        public class PJuridica : Contribuinte
        {
            protected String cnpj;
            protected double faturamento;
            public PJuridica(String n, string end, double f, String c)
            {
                this.nome = n;
                this.endereco = end;
                faturamento = f;
                cnpj = c;

                Console.WriteLine(nome + " imposto de " + calcImposto());

            }
            public override double calcImposto()
            {
                return (faturamento * 0.1);
            }
        }
        public abstract class Contribuinte
        {
            protected String nome;
            protected String endereco;
            public static Contribuinte[] listaContr()
            {
                Contribuinte[] lst = new Contribuinte[6];
                lst[0] = new PFisica("Joao Santos", "Rua abc, 123", 3000.00, "11111");
                lst[1] = new PJuridica("Lojas AA", "Rua Hum, 111", 150000.00, "10055");
                lst[2] = new PFisica("Maria Soares", "Av. Xyz, 777", 5000.00, "22222");
                lst[3] = new PJuridica("Supermercados B", "Rua Dois, 987", 2000000.00, "10066");
                lst[4] = new PFisica("Carla Maia", "Av. Três, 333", 1500.00, "33333");
                lst[5] = new PJuridica("Posto XX", "Rua Cinco, 555", 500000.00, "10077");

                return lst;
            }
            public String getNome()
            {
                return nome;
            }
            abstract public double calcImposto();
        }
        static void Main(string[] args)
        {
			Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário\n\n");
            Contribuinte.listaContr();
            Console.ReadKey();
        }
    }
}