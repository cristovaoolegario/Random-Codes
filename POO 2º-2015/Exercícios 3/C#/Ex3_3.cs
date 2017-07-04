using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_3
{
    class Program
    {
        interface IConta
        {
            string nome_do_titular{get;set;}
            int num_conta { get; set; }
            void Deposita(double valor);
            void Saca(double valor);
            double Saldo { get; set; }
            void preenche(string titular, int num);
        }
        class ContaCorrente : IConta
        {
            public double Saldo { get; set; }
            public string nome_do_titular { get; set; }
            public int num_conta { get; set; }
            private double taxaPorOperacao = 0.45;
            public void Deposita(double valor)
            {
                this.Saldo += valor - this.taxaPorOperacao;
            }
            public void Saca(double valor)
            {
                if (valor < this.Saldo)
                {
                    this.Saldo -= valor + this.taxaPorOperacao;
                }
                else
                {
                    Console.WriteLine("operação inváida");
                }
            }
            public void preenche(string titular, int num)
            {
                this.nome_do_titular = titular;
                this.num_conta = 100+num;
            }
        }
        class ContaPoupanca : IConta
        {
            public double Saldo { get; set; }
            public string nome_do_titular { get; set; }
            public int num_conta { get; set; }
            public void Deposita(double valor)
            {
                this.Saldo += valor;
            }
            public void Saca(double valor)
            {
                if (valor < this.Saldo)
                {
                    this.Saldo -= valor;
                }
                else
                {
                    Console.WriteLine("operação inváida");
                }
            }
            public void preenche(string titular, int num)
            {
                this.nome_do_titular = titular;
                this.num_conta = 200+num;
            }
        }
        class GeradorDeExtrato
        {
            public void GeraExtrato(IConta c)
            {
                System.Console.WriteLine(" EXTRATO ");
                System.Console.WriteLine(" SALDO : " + c.Saldo);
            }
        }
        public void percorreVetor() { }
        static void Main(String[] args)
        {
			Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário\n\n");
            IConta[] vet = new IConta[100];//armazenamento das contas.

            int indice = 0, i = 0;
            string tipo_de_conta;
            while (indice != 7)
            {
                Console.WriteLine("[1] - Criar uma nova conta");
                Console.WriteLine("[2] - Excluir uma conta");
                Console.WriteLine("[3] - Depositar em uma conta");
                Console.WriteLine("[4] - Sacar de uma conta");
                Console.WriteLine("[5] - Imprimir o extrato de uma conta");
                Console.WriteLine("[6] - Imprimir uma relação das contas existentes");
                Console.WriteLine("[7] - Sair do programa");
                indice = Convert.ToInt32(Console.ReadLine());

                switch (indice)
                {
                    case 1:
                        string nome;
                       
                        Console.WriteLine("Digite o tipo de conta");
                        tipo_de_conta = Console.ReadLine();
                        Console.WriteLine("Digite seu nome");
                        nome = Console.ReadLine();
                        

                        if (tipo_de_conta == "corrente") 
                        {
                            vet[i] = new ContaCorrente();
                            vet[i].preenche(nome, i);
                            Console.WriteLine("O número da sua conta é: " + vet[i].num_conta);
                        }
                        else if (tipo_de_conta == "poupanca") 
                        {
                            vet[i] = new ContaPoupanca();
                            vet[i].preenche(nome, i);
                            Console.WriteLine("O número da sua conta é: " + vet[i].num_conta);
                        }
                        i++;
                        break;
                    case 2:
                        
                        Console.WriteLine("Digite o numero da conta a ser excluida");
                        int num = Convert.ToInt32(Console.ReadLine());
                        int g;
                        for ( g = 0; g < vet.Length; g++)
                        {
                            try
                            {
                                if (num == vet[g].num_conta)
                                {
                                    vet[g] = null;
                                    g = vet.Length;
                                    Console.WriteLine("Conta excluída");
                                }
                            }
                            catch (NullReferenceException)
                            {

                            }
                        }
                        if(g == 100)
                        {
                            Console.WriteLine("Conta nao encontrada");
                        }                        
                        break;
                    case 3:

                        Console.WriteLine("Digite o número da conta");
                        int nume = Convert.ToInt32(Console.ReadLine());

                        for (g = 0; g < vet.Length; g++)
                        {
                            try
                            {
                                if (nume == vet[g].num_conta)
                                {
                                    Console.WriteLine("Conta encontrada");
                                    Console.WriteLine("Digite o valor a ser depositado");
                                    double deposito = Convert.ToDouble(Console.ReadLine());
                                    vet[g].Deposita(deposito);
                                    g = vet.Length;
                                }
                            }
                            catch (NullReferenceException) { }
                        }
                        if (g == 100)
                        {
                            Console.WriteLine("Conta nao encontrada");
                        }                                             

                        break;

                    case 4:
                        Console.WriteLine("Digite o numero da conta a ser sacada");
                        nume = Convert.ToInt32(Console.ReadLine());

                        for (g = 0; g < vet.Length; g++)
                        {
                            try
                            {
                                if (nume == vet[g].num_conta)
                                {
                                    Console.WriteLine("Conta encontrada");
                                    Console.WriteLine("Digite o valor a ser sacado");
                                    double saque = Convert.ToDouble(Console.ReadLine());
                                    vet[g].Saca(saque);
                                    g = vet.Length;
                                }
                            }
                            catch (NullReferenceException) { }
                        }
                        if (g == 100)
                        {
                            Console.WriteLine("Conta nao encontrada");
                        }                                  
                           
                        break;

                    case 5:
                         Console.WriteLine("Digite o numero da conta");
                        nume = Convert.ToInt32(Console.ReadLine());

                         for (g = 0; g < vet.Length; g++)
                         {
                             try
                             {
                                 if (nume == vet[g].num_conta)
                                 {
                                     Console.WriteLine("Conta encontrada");
                                     Console.WriteLine("Seu saldo é de : R$ " + vet[g].Saldo);
                                     g = vet.Length;
                                 }
                             }
                             catch (NullReferenceException) { }
                        }
                         if (g == 100) { Console.WriteLine("Conta nao encontrada"); }                         

                        break;
                    case 6:
                        int aux = 0;
                        Console.WriteLine("Relação das contas existentes :");
                        for (g = 0; g < vet.Length; g++)
                        {                           
                                if (vet[g] != null)
                                {
                                    Console.WriteLine("\nNome : " + vet[g].nome_do_titular + "\nNúmero da conta : " + vet[g].num_conta);                                   
                                }
                                else
                                {
                                    aux++;
                                }
                        }
                        if (aux == 100)
                        {
                            Console.WriteLine("\nNão há contas para serem exibidas\n");
                        }

                        break;
                    case 7:
                        break;

                }
                
            }
            
        }
       
    }
}