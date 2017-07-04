using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_4
{
    class Telefone
    {
        protected string TipodoTelefone = " ";

        public virtual void Ring()
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
            public override void Ring()
            {
                Console.WriteLine("Mensagem Diferente");
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