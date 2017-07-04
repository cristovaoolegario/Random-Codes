using System;

// Demosntra o uso da mensagem, propriedades StackTrace e InnerException 
class Properties
{
   static void Main( string[] args )
   {
	  // Chama o metodo1, qualquer excessao gerada irá ser
	  // pega pelo bloco catch que segue
      try 
      {
         Method1();
      }

		 // Representação da string de saida da excessao, 
		 // entao valores de saida da InnerException, mensagem 
		 // propriedades da StackTrace 
      catch ( Exception exception ) 
      {
         Console.WriteLine( 
            "exception.ToString(): \n{0}\n",
            exception.ToString() ); 

         Console.WriteLine( "exception.Message: \n{0}\n",
            exception.Message );

         Console.WriteLine( "exception.StackTrace: \n{0}\n",
            exception.StackTrace );

         Console.WriteLine( 
            "exception.InnerException: \n{0}",
            exception.InnerException );

      } // Finaliza catch

   } // Finaliza Main

   // Chama o metodo2
   public static void Method1()
   {
      Method2();
   }

   // Chama o metodo3
   public static void Method2()
   {
      Method3();
   }
   // Arremeca uma excessao contendo uma InnerException
   public static void Method3()
   {
      // Tentativa de converter uma string nao inteira para int 
      try 
      {
         Convert.ToInt32( "Not an integer" );
      }
		 // Pega a FormatException e converte ela em uma nova excessao
      catch ( FormatException error ) 
      {
         throw new Exception( 
            "Exception occurred in Method3", error );
      }

   } // Finaliza metodo3

} // Finaliza a classe usingException


/*
	//Este programa tem como objetivo captar qualquer tipo excessao causada pelo programa
	//e mostrar que e possivel criar um metodo que pegue qualquer tipo de excessao e a converta
	//em um tipo de excessao generico. Nesse caso ele tenta converter uma frase:"Not an integer"
	//em um numero inteiro. Nesse caso ocorrerá uma FormatException, porem ela foi convertida em
	//uma exception do tipo format. Com isso o usuario verá as informacoes dessa excessao.
*/
