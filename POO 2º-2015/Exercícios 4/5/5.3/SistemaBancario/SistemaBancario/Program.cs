using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
// NOME DO PROGRAMA: SistemaBancario 
// 
// PROGRAMADORES: 
// Pedro Lucas Duarte Faria(536589)  
// Samara Luiza da Silva(536592) 
// Andrew de Oliveira Duchini (537983)
// Cristóvão Olegário de Castro (536584)

// DATA: 29/10/2015 
// DESCRIÇÃO: Utilizado os conceitos de relacionamento entre classes, foi implementado o programa
// que simula o sistema bancario com classes como conta, fatura, cartão_de_credito, cliente, etc.
// A classes testes 
namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\tProgramadores: ");
            Console.WriteLine("\tAndrew de Oliveira Duchini (537983)");
            Console.WriteLine("\tCristóvão Olegário de Castro (536584)");
            Console.WriteLine("\tPedro Lucas Duarte Faria(536589)");
            Console.WriteLine("\tSamara Luiza da Silva(536592)");
            // Teste relacionamento entre clientes e cartão de crédito
            Cliente c = new Cliente();
            CartaoDeCredito cdc = new CartaoDeCredito();

            c.Nome = "José da Silva";
            cdc.Numero = 111111;

            cdc.cliente = c;

            //Teste relacionamento entre contas e agencias
            Agencia a = new Agencia();
            Conta conta = new Conta();

            a.numero = 178;
            conta.saldo = 1000.0;

            conta.agencia = a;

            //Teste dos métodos da classe Conta
            conta.deposita(1000);
            conta.imprimeExtrato();
            conta.saca(100);
            conta.imprimeExtrato();

            //Teste da classe FATURA
            Fatura f = new Fatura();
            f.adiciona(100);
            f.adiciona(200);
            f.imprimeDados();
            double multa = f.calculaMulta();

            Console.ReadKey();
        }
    }
}
