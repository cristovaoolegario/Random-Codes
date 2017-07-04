// nome do programa: Exercicio4_3.java
// programadores: Andrew de Oliveira Duchini, Cristóvão Olegário
// data:22/08/2015 
// descrição: Esse programa simula um conta de banco.
//entrada: Recebe uma das ordens do usuário, explicitas no menu.
//saída: Executa uma das ordens do usuário, mostradas no menu.

import java.io.IOException;
import java.io.*;

public class Conta
{
	double saldo = 0;
	int numero; 
	
	public void depositar(double valor)
	{
		saldo = saldo + valor;
	}
	public void fazerRetirada(double valor)
	{
		if(saldo < valor)
		{
			System.out.println("Saldo insuficiente!");
		}
		else
		{
			saldo = saldo - valor;
		}
	}
	public imprimeSaldo()
	{
		System.out.println("Saldo: {0}", saldo);
	}
}
public class Program
{
	public static void Main(String []args)
	{
		int opcao = -1;
		double valor;
		
		Conta C = new Conta();
		
		do{
			System.out.println("Digite 1 para fazer um deposito na conta");
			System.out.println("Digite 2 para fazer uma retirada na conta");
			System.out.println("Digite 3 para ver o saldo da conta");
			System.out.println("Digite 4 para fechar o programa");
			
			System.out.println("Digite a opcao: ");
			opcao = readLine();
			
			switch(argos)
			{
				case 1: System.out.println("Digite um valor: ");
						valor = readLine();
						C.depositar(valor);
				break;
				case 2:System.out.println("Digite um valor: ");
						valor = readLine();
						C.fazerRetirada(valor);
				break;
				case 3:C.imprimeSaldo();
				break;
				case 4:			
				break;
				default:System.out.println("Operacao invalida Inválido");
				break;	
			}				
		
		}while(opcao != 4);
	}
}