import java.io.IOException;
import java.io.*;

public class Program_Telefone
		{
			public static void main(String[] args)
			{
				Console.WriteLine("Programadores: Andrew de Oliveira Duchini\n\tCristóvão Olegário");
				TelefoneEletronico t = new TelefoneEletronico();
				t.Ring();     
			}
		}

    class Telefone
    {
        protected String TipodoTelefone = "";

        public void Ring()
        {
            System.out.println("Tocando o "+ TipodoTelefone);
        }
       
        public Telefone()
        {
            TipodoTelefone = " ";
        }
	}
        class TelefoneEletronico extends Telefone
        {
            public TelefoneEletronico() 
            {
                set("digital");
            }
            public void set(String set)
            {
                TipodoTelefone = set;
            }            
        }

		
        
    

