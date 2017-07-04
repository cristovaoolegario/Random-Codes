using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3._2
{
    class Conta
    {
        private String titular;
        private int agencia;
        private int numConta;
        private static int cont = 0;
        private int tipoConta;
        private Double saldo;

        private void inicializacao(String nome, int ag, int tipo, Double saldoInicial)
        {
            this.titular = nome;
            this.agencia = ag;
            this.tipoConta = tipo;
            this.saldo = saldoInicial;
            numConta = 100 + ag + tipo + Convert.ToInt32(saldoInicial);
            Console.WriteLine("Seu número de conta é :" + numConta);
        }

        public static int percorre_vetor(int numConta, Conta[] vetContas)
        {
            int pos = 0;

            for (int i = 0; i < vetContas.Length; i++)
            {
                try
                {
                    if (vetContas[i].numConta == numConta)
                    {
                        pos = i;
                        i = vetContas.Length;
                    }
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Conta inexistente");
                }
            }
            return ((pos));
        }
        public static void menu(int opcao, Conta[] vetContas, ref int j)
        {
            double credito = 0, saque = 0, saldoInicial = 0;
            int num_Conta = 0, ag = 0, tipo = 0;
            String nome = "";

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o seu nome");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite a agência");
                    ag = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o tipo de conta");
                    tipo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o saldo inicial");
                    saldoInicial = Convert.ToDouble(Console.ReadLine());
                    vetContas[j] = new Conta(nome, ag, tipo, saldoInicial);
                    j++;

                    break;
                case 2:
                    Console.WriteLine("Digite o número da conta a ser excluida");
                    num_Conta = Convert.ToInt32(Console.ReadLine());
                    vetContas[percorre_vetor(num_Conta, vetContas)].Excluir_Conta(num_Conta, vetContas);
                    break;
                case 3:
                    Console.WriteLine("Digite o número da conta na qual será depositada a quantia");
                    num_Conta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor a ser depositado");
                    credito = Convert.ToDouble(Console.ReadLine());
                    vetContas[percorre_vetor(num_Conta, vetContas)].depositar(credito, num_Conta, vetContas);
                    break;
                case 4:
                    Console.WriteLine("Digite o número da conta na qual será sacada a quantia");
                    num_Conta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor a ser sacado");
                    saque = Convert.ToDouble(Console.ReadLine());
                    vetContas[percorre_vetor(num_Conta, vetContas)].sacar(saque, num_Conta, vetContas);
                    break;
                case 5:
                    Console.WriteLine("Digite o número da conta a ter o saldo impresso");
                    num_Conta = Convert.ToInt32(Console.ReadLine());
                    vetContas[percorre_vetor(num_Conta, vetContas)].ImprimeSaldo(num_Conta, vetContas);
                    break;
                case 6:
                    try
                    {
                        vetContas[0].ImprimeContas(vetContas);
                    }
                    catch (NullReferenceException)
                    {
                        Console.WriteLine("Contas inexistentes");
                    }
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Opção não existente, Tente novamente");
                    break;
            }
        }

        public Conta(string nome, int ag, int tipo, Double saldoInicial)
        {
            inicializacao(nome, ag, tipo, saldoInicial);
        }
        public void Excluir_Conta(int Num_conta, Conta[] vetContas)
        {
            int pos = percorre_vetor(Num_conta, vetContas);
            vetContas[pos] = null;
        }
        public double obterSaldo(int numConta, Conta[] vetContas)
        {
            return (vetContas[percorre_vetor(numConta, vetContas)].saldo);
        }
        public void depositar(double credito, int num_Conta, Conta[] vetContas)
        {
            try
            {
                if (credito > 0)
                {
                    vetContas[percorre_vetor(numConta, vetContas)].saldo += credito;
                }
                else
                {
                    Console.WriteLine("Operação Impossível");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Caracter digitado inválido, formato incorreto");
            }
        }
        public void sacar(double quantia, int numConta, Conta[] vetContas)
        {
            try
            {
                if (vetContas[percorre_vetor(numConta, vetContas)].saldo >= quantia)
                {
                    vetContas[percorre_vetor(numConta, vetContas)].saldo -= quantia;
                }
                else
                {
                    Console.WriteLine("O valor não pode ser sacado devido a falta de crédito");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Caracter digitado inválido, formato incorreto");
            }
        }
        public void ImprimeSaldo(int numConta, Conta[] vetContas)
        {
            Console.WriteLine("Seu saldo disponível é de R$ {0}", Convert.ToString(vetContas[percorre_vetor(numConta, vetContas)].saldo));
        }
        public void ImprimeContas(Conta[] vetContas)
        {
            for (int i = 0; i < vetContas.Length; i++)
            {
                if (vetContas[i] == null) 
                { 
                
                }
                else
                {
                    Console.WriteLine("\nNúmero da Conta :" + vetContas[i].numConta + "\nTitular : " + vetContas[i].titular);
                }
            }
        }


        static void Main(string[] args)
        {
			Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário");
            const int MAXCONTAS = 100;
            int j = 0;

            Conta[] vetContas = new Conta[MAXCONTAS];

            int opcao = 0;

            do
            {
                Console.WriteLine("1. Criar um conta nova.\n2. Excluir uma conta existente\n3. Depositar em uma conta\n4. Sacar de em uma conta\n5. Imprimir saldo de uma conta\n6. Imprimir uma relação das contas existentes\n7. Sair do programa");
                opcao = Convert.ToInt32(Console.ReadLine());
                menu(opcao, vetContas, ref j);

            } while (opcao != 7);




            Console.ReadKey();
        }
    }
}