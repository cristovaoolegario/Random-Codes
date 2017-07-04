using System;
//
// NOME DO PROGRAMA: Veiculo 
// 
// PROGRAMADORES: 
// Pedro Lucas Duarte Faria(536589)  
// Samara Luiza da Silva(536592) 
// Andrew de Oliveira Duchini (537983)
// Cristóvão Olegário de Castro (536584)

// DATA: 29/10/2015 
// DESCRIÇÃO: Utilizando os conceitos de composição e agregação, foi implementado 
// o programa que contém uma class Veiculo que é composta por motor, tanque e pneus
namespace Exercicio5_1
{
	class Veiculo
	{
		public Motor M = new Motor();
		public Tanque T = new Tanque();
		public Pneu PneuDianteiroEsq;
		public Pneu PneuDianteiroDir;
		public Pneu PneuTraseiroEsq;
		public Pneu PneuTraseiroDir;
		
		public Veiculo(Motor M, Tanque T, Pneu PneuDianteiroEsq, Pneu PneuDianteiroDir, Pneu PneuTraseiroEsq, Pneu PneuTraseiroDir)
		{
			this.M = M;
			this.T = T;
			this.PneuDianteiroEsq = PneuDianteiroEsq;
			this.PneuDianteiroDir = PneuDianteiroDir;
			this.PneuTraseiroEsq = PneuTraseiroEsq;
			this.PneuTraseiroDir = PneuTraseiroDir;
		}
	}
	class Motor
	{
		float potencia;
		float consumo;
		Tanque Combustivel;
		Pneu PneuDianteiroEsq;
		Pneu PneuDianteiroDir;
		Pneu PneuTraseiroEsq;
		Pneu PneuTraseiroDir;
		
		public Motor(float potencia, float consumo, Tanque Combustivel)
		{
			this.potencia = potencia;
			this.consumo = consumo;
			this.Combustivel = Combustivel;
		}
		public void avancaKilometragem(float kilometro)
		{
			float resultado = 0;
			
			if(	(PneuDianteiroDir.pressao > 20 && PneuDianteiroEsq.pressao > 20) || 
				(PneuTraseiroDir.pressao  > 20 &&  PneuTraseiroEsq.pressao > 20) || 
				(PneuDianteiroEsq.pressao > 20 && PneuTraseiroEsq.pressao > 20) || 
				(PneuDianteiroDir.pressao > 20 && PneuTraseiroDir.pressao > 20)||
				(PneuDianteiroDir.pressao > 20 && PneuTraseiroEsq.pressao > 20)||
				(PneuDianteiroEsq.pressao > 20 && PneuTraseiroDir.pressao > 20))
			{
				consumo = consumo * 1.3f;
			}
			resultado = Combustivel.QtdAtual * consumo;
			
			if((resultado = resultado - kilometro) < 0)
			{
				Combustivel.QtdAtual = 0;
			}
			else
			{
				resultado = kilometro / consumo;
				Combustivel.QtdAtual = resultado;
			}
		}
	}
	class Tanque
	{
		float capacidade;
		float qtdAtual;
		float capacidadeMax;
		
		public Tanque(float capacidade, float qtdAtual, float capacidadeMax)
		{
			this.capacidade = capacidade;
			this.qtdAtual = qtdAtual;
			this.capacidadeMax = capacidadeMax;
		}
		public void abastece(float qtd)
		{
			if((qtdAtual += qtd) > capacidadeMax)
			{
				qtdAtual = capacidadeMax;
			}
			else
			{
				qtdAtual += qtd;
			}
		}
		public float QtdAtual
		{
			get{return qtdAtual;} 
			set{qtdAtual = value;}
		}
	}
	class Pneu
	{
		public float pressao;
		
		public Pneu(float pressao)
		{
			this.pressao = pressao;
		}
		public float Calibra 
		{
			get{return pressao;}
			set{pressao += value;}
	    }
	}
	class Program
	{
		static void Main()
		{
			float potencia = 71;
			float consumo = 12;
			float capacidadeMax = 50;
			float capacidade = capacidadeMax;
			
			/*
			Console.WriteLine("Digite a potencia do motor: ");
			potencia = float.parse(Console.ReadLine());
			
			Console.WriteLine("Digite o consumo do motor: ");
			consumo = float.parse(Console.ReadLine());
			
			Console.WriteLine("Digite a capacidade maxima do tanque: ");
			capacidadeMax = float.parse(Console.ReadLine());
			*/
			
			Tanque T = new Tanque(capacidade, 0, capacidadeMax);
			Motor M = new Motor(potencia, consumo, T);
			Pneu P1 = new Pneu(27);
			Pneu P2 = new Pneu(27);
			Pneu P3 = new Pneu(23);
			Pneu P4 = new Pneu(23);
			Veiculo V = new Veiculo(M, T, P1, P2, P3, P4);
			
			V.T.abastece(50);
			
			V.M.avancaKilometragem(300);
			V.PneuTraseiroEsq.Calibra = -17;
			V.M.avancaKilometragem(100);
			V.PneuDianteiroEsq.Calibra = -18;
			V.T.abastece(10);
			try {
				V.M.avancaKilometragem(200);
			}
			catch {}
			
			Console.ReadKey();
		}
	}
}