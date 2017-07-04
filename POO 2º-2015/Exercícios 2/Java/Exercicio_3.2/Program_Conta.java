import java.io.IOException;
import java.io.*;
import java.util.Scanner;

class Conta_Funcional
    {
        private String titular;
        private int agencia;
        private int numConta;
        private static int cont = 0;
        private int tipoConta;
        private Double saldo;
		
		public int j;

        private void inicializacao(String nome, int ag, int tipo, Double saldoInicial)
        {
            this.titular = nome;
            this.agencia = ag;
            this.tipoConta = tipo;
            this.saldo = saldoInicial;
            numConta = 100 + ag + tipo +j;
            System.out.println("Seu número de conta é :" + numConta);
        }

        public static int percorre_vetor(int numConta, Conta_Funcional[] vetContas)
        {
            int pos = 0;

            for (int i = 0; i < vetContas.length; i++)
            {
                try
                {
                    if (vetContas[i].numConta == numConta)
                    {
                        pos = i;
                        i = vetContas.length;
                    }
                }
                catch (NullPointerException e)
                {
                    System.out.println("Conta inexistente");
                }
            }
            return ((pos));
        }
        public static void menu(int opcao, Conta_Funcional[] vetContas, int j, Scanner ler)
        {
            double credito = 0, saque = 0, saldoInicial = 0;
            int num_Conta = 0, ag = 0, tipo = 0;
            String nome = "";

            switch (opcao)
            {
                case 1:
                    System.out.println("Digite o seu nome");
                    nome = ler.next();
                    System.out.println("Digite a agência");
                    ag = ler.nextInt();
                    System.out.println("Digite o tipo de conta");
                    tipo = ler.nextInt();
                    System.out.println("Digite o saldo inicial");
                    saldoInicial = ler.nextDouble();
                    vetContas[j] = new Conta_Funcional(nome, ag, tipo, saldoInicial);
                    j++;

                    break;
                case 2:
                    System.out.println("Digite o número da conta a ser excluida");
                    num_Conta = ler.nextInt();
                    vetContas[percorre_vetor(num_Conta, vetContas)].Excluir_Conta(num_Conta, vetContas);
                    break;
                case 3:
                    System.out.println("Digite o número da conta na qual será depositada a quantia");
                    num_Conta = ler.nextInt();
                    System.out.println("Digite o valor a ser depositado");
                    credito = ler.nextDouble();
                    vetContas[percorre_vetor(num_Conta, vetContas)].depositar(credito, num_Conta, vetContas);
                    break;
                case 4:
                    System.out.println("Digite o número da conta na qual será sacada a quantia");
                    num_Conta = ler.nextInt();
                    System.out.println("Digite o valor a ser sacado");
                    saque = ler.nextDouble();
                    vetContas[percorre_vetor(num_Conta, vetContas)].sacar(saque, num_Conta, vetContas);
                    break;
                case 5:
                    System.out.println("Digite o número da conta a ter o saldo impresso");
                    num_Conta = ler.nextInt();
                    vetContas[percorre_vetor(num_Conta, vetContas)].ImprimeSaldo(num_Conta, vetContas);
                    break;
                case 6:
                    try
                    {
                        vetContas[0].ImprimeContas(vetContas);
                    }
                    catch (NullPointerException e)
                    {
                        System.out.println("Contas inexistentes");
                    }
                    break;
                case 7:
                    break;
                default:
                    System.out.println("Opção não existente, Tente novamente");
                    break;
            }
        }

        public Conta_Funcional(String nome, int ag, int tipo, double saldoInicial)
        {
            inicializacao(nome, ag, tipo, saldoInicial);
        }
        public void Excluir_Conta(int Num_conta, Conta_Funcional[] vetContas)
        {
            int pos = percorre_vetor(Num_conta, vetContas);
            vetContas[pos] = null;
        }
        public double obterSaldo(int numConta, Conta_Funcional[] vetContas)
        {
            return (vetContas[percorre_vetor(numConta, vetContas)].saldo);
        }
        public void depositar(double credito, int num_Conta, Conta_Funcional[] vetContas)
        {
            try
            {
                if (credito > 0)
                {
                    vetContas[percorre_vetor(numConta, vetContas)].saldo += credito;
                }
                else
                {
                    System.out.println("Operação Impossível");
                }
            }
            catch (NumberFormatException e)
            {
                System.out.println("Caracter digitado inválido, formato incorreto");
            }
        }
        public void sacar(double quantia, int numConta, Conta_Funcional[] vetContas)
        {
            try
            {
                if (vetContas[percorre_vetor(numConta, vetContas)].saldo >= quantia)
                {
                    vetContas[percorre_vetor(numConta, vetContas)].saldo -= quantia;
                }
                else
                {
                    System.out.println("O valor não pode ser sacado devido a falta de crédito");
                }
            }
            catch (NumberFormatException e)
            {
                System.out.println("Caracter digitado inválido, formato incorreto");
            }
        }
        public void ImprimeSaldo(int numConta, Conta_Funcional[] vetContas)
        {
            System.out.println("Seu saldo disponível é de R$ "+ vetContas[percorre_vetor(numConta, vetContas)].saldo);
        }
        public void ImprimeContas(Conta_Funcional[] vetContas)
        {
            for (int i = 0; i < vetContas.length; i++)
            {
                if (vetContas[i] == null) 
                { 
                
                }
                else
                {
                    System.out.println("\nNúmero da Conta :" + vetContas[i].numConta + "\nTitular : " + vetContas[i].titular);
                }
            }
        }
	}
	
	public class Program_Conta
	{
        public static void main(String[] args)
        {
			Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário");
            int MAXCONTAS = 100;
            int j = 0;
			Scanner ler = new Scanner(System.in);
            Conta_Funcional[] vetContas = new Conta_Funcional[MAXCONTAS];

            int opcao = 0;

            do
            {
                System.out.println("1. Criar um conta nova.\n2. Excluir uma conta existente\n3. Depositar em uma conta\n4. Sacar de em uma conta\n5. Imprimir saldo de uma conta\n6. Imprimir uma relação das contas existentes\n7. Sair do programa");
                opcao = ler.nextInt();
                vetContas[0].menu(opcao, vetContas, j, ler);

            } while (opcao != 7);
        }
    }