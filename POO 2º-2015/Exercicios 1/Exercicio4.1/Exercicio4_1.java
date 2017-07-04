// nome do programa: Exercicio4_1.java
// programadores: Andrew de Oliveira Duchini, Cristóvão Olegário
// data:22/08/2015 
// descrição: Esse programa implementa uma calculadora, com as quatro operações básicas com números reais.
//entrada: Recebe um número, uma operação e um segundo número.
//saída: Retorna o resultado da operação.

import java.io.IOException;
import java.io.*;

public class Exercicio4_1
{
	public static float multiplição(float a, float b)
	{
		return(a*b);
	}
	public static float divisão(float a, float b)
	{		
		if(b != 0)
		{				
			return(a/b);
		}
		else
		{
			System.out.println("Divisão por zero, Inválido");
		}		
	}
	public static float adição(float a, float b)
	{
		return(a+b);
	}
	public static float subtração(float a, float b)
	{
		return(a-b);
	}
	public static void operação(String argos, ref float vet, float a, float b)
	{
		switch(argos)
		{
			
			case "x":
				vet = multiplição(float a, float b);
				break;
			case "/":
				vet = divisão(float a, float b);
				break;
			case "+":
				vet = adição(float a, float b);
				break;
			case "-":
				vet = subtração(float a, float b);			
				break;
			default:
			System.out.println("Operador Inválido");
				break;			
		}
		System.out.println("{0}{1}{2} = {3}",a,argos,b,vet);
	}
	public static void main(String[] args)
	{
		float[] vet = new float[3];
		vet[0] = Float.parseFloat(args[0]);
		vet[1] = Float.parseFloat(args[2]);
		operação(args[1], vet[2], vet[0], bet[1]);
		System.in.read;		
	}
}