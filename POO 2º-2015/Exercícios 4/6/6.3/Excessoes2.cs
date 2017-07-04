// Fig 11.5: SquareRootTest.cs
// Demonstrating a user-defined exception class.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NegativeNumberSquareRoot
{   
   /// <summary>
   /// Aceita a entrada e computa a raiz quadrada da entrada
   /// </summary>
   public class SquareRootTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label inputLabel;
      private System.Windows.Forms.Label outputLabel;

      private System.Windows.Forms.TextBox inputTextBox;

      private System.Windows.Forms.Button squareRootButton;

      /// <summary>
	  /// Requer variavel designada
      /// </summary>
      private System.ComponentModel.Container components = null;

      // Construtor padrao
      public SquareRootTest()
      {
         //
         // requerido pelo suporte de designer windons form 
         //
         InitializeComponent();
      }

      /// <summary>
      /// limpa qualquer recurso alocado
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if ( disposing )
         {
            if ( components != null ) 
            {
               components.Dispose();
            }
         }

         base.Dispose( disposing );
      }

		#region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
	  /// Metodo requerido para suporte do designer -não modifique
	  /// o conteudo desse metodo com o editor do codigo
      /// </summary>
      private void InitializeComponent()
      {
		//Metodo responsavel por criar os botoes que serao vistos na tela.
         this.outputLabel = new System.Windows.Forms.Label();
         this.squareRootButton = new System.Windows.Forms.Button();
         this.inputTextBox = new System.Windows.Forms.TextBox();
         this.inputLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // Label de saida
         // 
         this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.outputLabel.Location = new System.Drawing.Point(14, 71);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(264, 23);
         this.outputLabel.TabIndex = 2;
         // 
         // Bota de raiz quadrada
         // 
         this.squareRootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.squareRootButton.Location = new System.Drawing.Point(90, 37);
         this.squareRootButton.Name = "squareRootButton";
         this.squareRootButton.Size = new System.Drawing.Size(112, 27);
         this.squareRootButton.TabIndex = 1;
         this.squareRootButton.Text = "Square Root";
         this.squareRootButton.Click += new System.EventHandler(this.squareRootButton_Click);
         // 
         // Caixa de entrada de texto
         // 
         this.inputTextBox.Location = new System.Drawing.Point(164, 8);
         this.inputTextBox.Name = "inputTextBox";
         this.inputTextBox.TabIndex = 3;
         this.inputTextBox.Text = "";
         // 
         // Label de entrada
         // 
         this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.inputLabel.Location = new System.Drawing.Point(28, 10);
         this.inputLabel.Name = "inputLabel";
         this.inputLabel.Size = new System.Drawing.Size(124, 16);
         this.inputLabel.TabIndex = 0;
         this.inputLabel.Text = "Please enter a number:";
         // 
         // Teste de raiz quadrada
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(292, 100);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.inputTextBox,
                                                                      this.outputLabel,
                                                                      this.squareRootButton,
                                                                      this.inputLabel});
         this.Name = "SquareRootTest";
         this.Text = "Computing the Square Root";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// Ponte de entrada principal do programa
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new SquareRootTest() );
      } 

	  //computa a raiz quadrada de seus parametros; arremessa
	  //NegativeNumberException se o parametro é negativo
      public double SquareRoot( double operand )
      {
		 // Se operando negativo, arremessa NegativeNumberException
         if ( operand < 0 )
            throw new NegativeNumberException( 
               "Square root of negative number not permitted" );

         // compute the square root
         return Math.Sqrt( operand );

      } // finaliza classe raiz quadrada

      // obtain user input, convert to double and calculate
	  // Obtem a entrada do usuario, converte para double e calcula
	  // razi quadrada
      private void squareRootButton_Click(
         object sender, System.EventArgs e )
      {
         outputLabel.Text = "";

		 // Pega qualquer NegativeNumberException 
         try
         {
            double result = 
               SquareRoot( Double.Parse( inputTextBox.Text ) );

            outputLabel.Text = result.ToString();
         }

            // processa numero no formato errado
         catch ( FormatException notInteger )
         {
            MessageBox.Show( notInteger.Message, 
               "Invalid Number Format", MessageBoxButtons.OK, 
               MessageBoxIcon.Error );
         }
			// Exibe a caixa de mensagem se numero de entrada for negativo
         catch ( NegativeNumberException error )
         {
            MessageBox.Show( error.Message, "Invalid Operation", 
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         }

      } // Finaliza metodo squareRootButton_Click
     
   } // finaliza classe SquareRootTest
}
/*
	Esse programa tem como finalidade desenhar na tela botões para receber um numero 
	do usuario e com isso calcular sua raiz quadrada. Com a entrada dos valores, sera
	feita uma analise para verificar se os valores entrados são corretos. Vemos se o numero
	entrado é negativo e se o usuario entrou com um caracter ao invez de um numero. Ao final 
	do programa vemos o resultado da raiz quadrada do numero.
*/
