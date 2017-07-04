using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
// NOME DO PROGRAMA: Agenda 
// 
// PROGRAMADORES: 
// Pedro Lucas Duarte Faria(536589)  
// Samara Luiza da Silva(536592) 
// Andrew de Oliveira Duchini (537983)
// Cristóvão Olegário de Castro (536584)

// DATA: 29/10/2015 
// DESCRIÇÃO: Seguindo os conceitos de relacionamentos entre classes o programa
// Cria uma classe Agenda que é agregado a contatos que por sua vez é agregada a pessoas.
// Permite que o usuário entre com contatos, consulte um  contato e imprima a relação de contatos
namespace Agenda
{
    class Agenda
    {
        // Atributos
        public static int contador = 0;
        public static List<Contato> contatos = new List<Contato>();
        // Métodos
        static public void Addcontato (Contato cont)
        {
            contador++;
            Console.WriteLine("\nContato nº" + contador);
            contatos.Add(cont);
        }
    }
    struct Date
    {
        public int dia;
        public int mes;
        public int ano;

    }
    class Contato
    {
        Pessoa contato;

        public Contato(Pessoa a)
        {
            this.contato = a;
        }
        
        public void Imprime()
        {
            contato.ImprimeDados();
        }

    }
    class Pessoa
    {
        protected string nome;
        protected string endereço;
        protected Date data = new Date();
        

        public virtual void ImprimeDados()
        {
            Console.WriteLine("NOME: "+nome);
            Console.WriteLine("ENDEREÇO: "+endereço);
            Console.WriteLine("DATA: "+data.dia+"/"+data.mes+"/"+data.ano);
        }
    }
    class PessoaFisica : Pessoa
    {
        private char sexo;
        private string cpf;

        public PessoaFisica (string name, string end, Date data, char sexo, string CPF) 
        {
            this.nome = name;
            this.endereço = end;
            this.data = data;
            this.cpf = CPF;
            this.sexo = sexo;
        }
        public override void ImprimeDados()
        {
            base.ImprimeDados();
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("SEXO: " + sexo);
            Console.WriteLine();
        }
    }
    class PessoaJuridica : Pessoa
    {
        
        private string CNPJ;

        public PessoaJuridica (string name, string end, Date data, string CNPJ) 
        {
            this.nome = name;
            this.endereço = end;
            this.data = data;
            this.CNPJ = CNPJ;
          
        }
        public override void ImprimeDados()
        {
            base.ImprimeDados();
            Console.WriteLine("CNPJ: " + CNPJ);
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Cadastro()
        {
            int op;
            string nome;
            string endereço;
            Date data = new Date();
            char sexo;
            string cpf;

            Console.WriteLine("1 - Pessoa Fisica");
            Console.WriteLine("2 - Pessoa Juridica");
            op = int.Parse(Console.ReadLine());
            
            if (op==1)
            {
                Console.Write("NOME: ");
                nome = Console.ReadLine();
                Console.Write("ENDEREÇO: ");
                endereço = Console.ReadLine();
                Console.Write("DIA: ");
                data.dia = int.Parse(Console.ReadLine());
                Console.Write("MÊS: ");
                data.mes = int.Parse(Console.ReadLine());
                Console.Write("ANO: ");
                data.ano = int.Parse(Console.ReadLine());
                Console.Write("SEXO: ");
                sexo = char.Parse(Console.ReadLine());
                Console.Write("CPF: ");
                cpf = Console.ReadLine();
                PessoaFisica a = new PessoaFisica(nome, endereço, data, sexo, cpf);
                Contato b = new Contato(a);
                Agenda.Addcontato(b);
            }
            else if (op==2)
            {
                Console.Write("NOME: ");
                nome = Console.ReadLine();
                Console.Write("ENDEREÇO: ");
                endereço = Console.ReadLine();
                Console.Write("DIA: ");
                data.dia = int.Parse(Console.ReadLine());
                Console.Write("MÊS: ");
                data.mes = int.Parse(Console.ReadLine());
                Console.Write("ANO: ");
                data.ano = int.Parse(Console.ReadLine());
                Console.Write("CNPJ: ");
                cpf = Console.ReadLine();
                PessoaJuridica a = new PessoaJuridica(nome, endereço, data, cpf);
                Contato b = new Contato(a);
                Agenda.Addcontato(b);
            }
            else
            {
                Console.WriteLine("Digite uma opção válida!");
            }
        }
        static void Consulta()
        {
            int aux = 0;
            Console.Write("Digite o número do contato: ");
            aux = int.Parse(Console.ReadLine());
            Agenda.contatos[aux - 1].Imprime();
        }
        static void Main(string[] args)
        {
            Console.Write("\tProgramadores: ");
            Console.WriteLine("\tAndrew de Oliveira Duchini (537983)");
            Console.WriteLine("\tCristóvão Olegário de Castro (536584)");
            Console.WriteLine("\tPedro Lucas Duarte Faria(536589)");
            Console.WriteLine("\tSamara Luiza da Silva(536592)");
            Console.WriteLine();
            int op = 0;
            do
            {
                Console.WriteLine("1 - Adcionar contato");
                Console.WriteLine("2 - Consultar contato");
                Console.WriteLine("3 - Imprimir contatos");
                Console.WriteLine("4 - Sair");
                Console.WriteLine();
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1: Cadastro(); Console.WriteLine(); break;
                    case 2: Consulta(); Console.WriteLine(); break;
                    case 3: for (int i = 0; i < Agenda.contador ; i++)
                        {
                            Agenda.contatos[i].Imprime();
                        } break;
                    case 4: Console.WriteLine("Saindo...."); Console.WriteLine("Pressione uma tecla!"); break;
                    default: Console.WriteLine("ERRO! Opção inválida"); break;
                }
            } while (op != 4);
            Console.ReadKey();
        }
    }
}
