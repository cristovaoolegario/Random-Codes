using System;

// Demonstra o uso de operadores checados e não checados
class Overflow
{
   static void Main( string[] args )
   {
      int number1 = Int32.MaxValue;  // 2,147,483,647
      int number2 = Int32.MaxValue;  // 2,147,483,647
      int sum = 0; 

      Console.WriteLine( 
         "number1: {0}\nnumber2: {1}", number1, number2 );

	  // Calcula o somatorio de number1 e number2
      try
      {
         Console.WriteLine( 
            "\nSum integers in checked context:" );

         sum = checked( number1 + number2 );
      }

         // Pega excessao de overflow
      catch ( OverflowException overflowException )
      {
         Console.WriteLine( overflowException.ToString() );
      }

      Console.WriteLine( 
         "\nsum after checked operation: {0}", sum );

      Console.WriteLine( 
         "\nSum integers in unchecked context:" );

      sum = unchecked( number1 + number2 );

      Console.WriteLine( 
         "sum after unchecked operation: {0}", sum );

   } // Finaliza metodo Main

} // 	Finaliza classe Overflow

/*
	Esse programa tem como objetivo detectar quando ocorre uma excessao
	do tipo Overflow. Essa excessao ocorre quando tentamos armazenar em
	uma variavel um valor superior ao valor suportado pelo tipo da variavel.
	Caso o usuario faça uma operacao, esse programa ira rodar, testando
	para ver se ocorrera uma soma que o resultado seja maior do que o 
	suportado pelo tipo da variavel.
*/
