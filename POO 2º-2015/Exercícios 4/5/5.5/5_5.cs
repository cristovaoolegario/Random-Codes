//
// NOME DO PROGRAMA: Ex5_5 
// 
// PROGRAMADORES: 
// Pedro Lucas Duarte Faria(536589)  
// Samara Luiza da Silva(536592) 
// Andrew de Oliveira Duchini (537983)
// Cristóvão Olegário de Castro (536584)

// DATA: 29/10/2015 
// DESCRIÇÃO: O programa implementa a class Pessoa que possui por composição
// enderenço, data e contato. No programa de teste, o usuário entra com seu dados 
// que são impressos logo depois 
using System;

namespace Ex5_5
{
	class Pessoa
	{
		Endereco E;
		Data D;
		Contato C;
		string nome;
		
		public string Nome{get{return nome;}}
		public Endereco e{get{return E;}}
		public Data d{get{return D;}}
		public Contato c{get{return C;}}
		
		public Pessoa(string nome)
		{
			E = new Endereco();
			D = new Data();
			C = new Contato();
			
			Console.WriteLine("Digite seu logradouro: ");
			E.Logradouro = Console.ReadLine();
			Console.WriteLine("Digite o numero: ");
			E.Numero = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite seu bairro: ");
			E.Bairro = Console.ReadLine();
			Console.WriteLine("Digite seu cidade: ");
			E.Cidade = Console.ReadLine();
			Console.WriteLine("Digite seu estado: ");
			E.Estado = Console.ReadLine();
			Console.WriteLine("Digite seu cep: ");
			E.Cep = Console.ReadLine();
			Console.WriteLine("Digite seu telefoneResidencial: ");
			C.TelefoneResidencial = Console.ReadLine();
			Console.WriteLine("Digite seu celular: ");
			C.Celular = Console.ReadLine();
			Console.WriteLine("Digite seu email: ");
			C.Email = Console.ReadLine();
			Console.WriteLine("Digite o ano: ");
			D.Ano = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite o mes: ");
			D.Mes = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite o dia: ");
			D.Dia = int.Parse(Console.ReadLine());
			
			this.nome = nome;
			
		}
	}
	class Endereco
	{
		string logradouro;
		int numero;
		string bairro;
		string cidade;
		string estado;
		string cep;
		
		public string Logradouro{get{return logradouro;}set{logradouro = value;}}
		public int Numero{get{return numero;}set{numero = value;}}
		public string Bairro{get{return bairro;}set{bairro = value;}}
		public string Cidade{get{return cidade;}set{cidade = value;}}
		public string Estado{get{return estado;}set{estado = value;}}
		public string Cep{get{return cep;}set{cep = value;}}
	}
	class Data
	{
		int dia;
		int mes;
		int ano;
		
		public int Dia{get{return dia;}set{dia = value;}}
		public int Mes{get{return mes;}set{mes = value;}}
		public int Ano{get{return ano;}set{ano = value;}}
	}
	class Contato
	{
		string telefoneResidencial;
		string celular;
		string email;
		
		public string TelefoneResidencial{get{return telefoneResidencial;}set{telefoneResidencial = value;}}
		public string Celular{get{return celular;}set{celular = value;}}
		public string Email{get{return email;}set{email = value;}}
	}
	class Program
	{
		public static void Main(string[] args)
		{	
		    Console.Write("\tProgramadores: ");
            Console.WriteLine("\tAndrew de Oliveira Duchini (537983)");
            Console.WriteLine("\tCristóvão Olegário de Castro (536584)");
            Console.WriteLine("\tPedro Lucas Duarte Faria(536589)");
            Console.WriteLine("\tSamara Luiza da Silva(536592)");
		
			string nome;
			
			Console.WriteLine("Digite seu nome: ");
			nome = Console.ReadLine();
			
			Pessoa P = new Pessoa(nome);
			
			Console.WriteLine("Nome: "+ P.Nome);
			Console.WriteLine();
			Console.WriteLine("Celular: "+ P.c.Celular);
			Console.WriteLine("Email: "+ P.c.Email);
			Console.WriteLine("Telefone Residencial: "+ P.c.TelefoneResidencial);
			Console.WriteLine();
			Console.Write("{0}/", P.d.Dia);
			Console.Write("{0}/", P.d.Mes);
			Console.Write("{0}", P.d.Ano);
			Console.WriteLine();
			
			Console.WriteLine("CEP: "+ P.e.Cep);
			Console.WriteLine("Logradouro: "+ P.e.Logradouro);
			Console.WriteLine("Bairro: "+ P.e.Estado);
			Console.WriteLine("Cidade: "+ P.e.Cidade);
			Console.WriteLine("Bairro: "+ P.e.Bairro);
			Console.WriteLine("Numero: "+ P.e.Numero);
			Console.WriteLine();
			
			
			Console.WriteLine();
			Console.ReadKey();
		}
	}
}