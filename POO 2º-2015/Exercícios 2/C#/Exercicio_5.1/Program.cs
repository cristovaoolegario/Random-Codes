using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_5._1
{
    class Telefone
    {
        protected string TipodoTelefone = " ";

        public void Ring()
        {
            Console.WriteLine("Tocando o {0}", TipodoTelefone);
        }
       
        public Telefone()
        {
            TipodoTelefone = "";
        }
        class TelefoneEletronico : Telefone
        {
            public TelefoneEletronico() 
            {
                set("digital");
            }
            public void set(string set)
            {
                TipodoTelefone = set;
            }            
        }

        static void Main(string[] args)
        {
			Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário");
            TelefoneEletronico t = new TelefoneEletronico();

            t.Ring();
            Console.ReadKey();
            
        }
        
    }
}
