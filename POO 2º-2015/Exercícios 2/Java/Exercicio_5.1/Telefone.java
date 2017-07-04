import java.io.IOException;
import java.io.*;

    class Telefone
    {
        protected String TipodoTelefone = " ";

        public void Ring()
        {
            System.out.println("Tocando o {0}", TipodoTelefone);
        }
       
        public Telefone()
        {
            TipodoTelefone = " ";
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

        static void mainain(String[] args)
        {
            TelefoneEletronico t = new TelefoneEletronico();
            t.Ring();     
        }
        
    }

