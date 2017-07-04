using System;

namespace NegativeNumberSquareRoot
{
   /// <summary>
   /// NegativeNumberException representam excessoes causadas por 
   /// operacoes ilegais realizadas com numeros negativos
   /// </summary>
   class NegativeNumberException : ApplicationException
   {
      // Construtor padrao
      public NegativeNumberException()
         : base( "Illegal operation for a negative number" )
      {
      }
	  // Construtor para mensagens de erro customizados
      public NegativeNumberException( string message )
         : base( message )
      {
      }

      // constructor for customizing error message and 
	  // Construtor para mensagens de erro customizados e especificadores de excessoes internas de objetos
      public NegativeNumberException( 
         string message, Exception inner ) 
         : base( message, inner )
      {
      }

   } 
	 //Finaliza a classe NegativeNumberException
}

/*
	Este programa tem como finalidade informar ao usuario que está
	sendo realizado uma operação ilegal com numeros negativos.
	Por exemplo caso o usuario esteja fazendo uma raiz quadrada
	de um numero, esse programa ira rodar, caso ocorra de a parcela
	ser um numero negativo, o programa irá informar que a operacao de 
	raiz quadrada não pode ser efetuada em numeros negativos.
*/
