import java.io.IOException;
import java.io.*;

class Funcionarios
{
	protected String nome;
	protected int RG;
	
	private Funcionarios(String nome, int RG)
	{
		this.nome = nome;
		this.RG = RG;		
	}	
}

class Vendedores extends Funcionarios
{
	public Double salario_base, comissao_por_vendas, salario_finall;
	public int quant_vendas;
	
	private Vendedores(double salario)
	{
		this.salario_base = salario;
		this.comissao_por_vendas = 0.5;
	}	
	public void vendas(int vendas_mes)
	{
		this.quant_vendas = vendas_mes;
	}
	public void salario_final()
	{
		salario_finall = salario_base + (vendas_mes*comissao_por_vendas);
		System.out.println(" O valor do seu salário final é R$ " + salario_finall);
	}
}

class ADM extends Funcionarios
{
		public Double salario_fixo;
		public int horas_extras;
		
		private ADM(double salario, int horas)
		{
			this.salario_fixo = salario;
			this.horas_extras = horas;
		}
		public void hora(int horas_mes)
		{
			this.horas_extras = horas_mes;
		}
		public void salario_final()
		{			
			System.out.println(" O valor do seu salário final é R$ " + (0.01*salario_fixo*horas_extras) + salario_fixo);
		}
		
}

public class Program_Funcionarios
{	
	public static void main(String[] args)
	{
		Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário");
	}
}