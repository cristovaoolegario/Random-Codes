// Fig 11.1: DivideByZeroTest.cs
// Basics of C# exception handling.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace divideZero1
{
   ///<Sumario>
   ///Essa classe demonstra como lidar com excecoes de 
   ///divisao por zero em integrações aritmeticas e de 
   ///formatos de expressoes numericas
   ///</Sumario>
   public class DivideByZeroTest : System.Windows.Forms.Form
   {
	//Criação dos botões e labels do programa
      private System.Windows.Forms.Label numeratorLabel;
      private System.Windows.Forms.TextBox numeratorTextBox;

      private System.Windows.Forms.Label denominatorLabel;
      private System.Windows.Forms.TextBox denominatorTextBox;

      private System.Windows.Forms.Button divideButton;
      private System.Windows.Forms.Label outputLabel;

      /// <summary>
      /// Requer variavel designada
      /// </summary>
      private System.ComponentModel.Container components = null;

      // Construtor Padrao
      public DivideByZeroTest()
      {
         // Requerido pelo designer do windons form
         InitializeComponent();
      }

      /// <summary>
	  /// Limpa qualquer recurso que estava sendo usado
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
	  //Inicializa as labels e os botoes que serao usados no programa
         this.divideButton = new System.Windows.Forms.Button();
         this.denominatorTextBox = new System.Windows.Forms.TextBox();
         this.numeratorTextBox = new System.Windows.Forms.TextBox();
         this.denominatorLabel = new System.Windows.Forms.Label();
         this.outputLabel = new System.Windows.Forms.Label();
         this.numeratorLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // Botao divisor
         // 
         this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.divideButton.Location = new System.Drawing.Point(16, 88);
         this.divideButton.Name = "divideButton";
         this.divideButton.Size = new System.Drawing.Size(120, 32);
         this.divideButton.TabIndex = 3;
         this.divideButton.Text = "Click to Divide";
         this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
         // 
         // Dominador da caixa de texto
         // 
         this.denominatorTextBox.Location = new System.Drawing.Point(136, 48);
         this.denominatorTextBox.Name = "denominatorTextBox";
         this.denominatorTextBox.Size = new System.Drawing.Size(120, 20);
         this.denominatorTextBox.TabIndex = 5;
         this.denominatorTextBox.Text = "";
         // 
         // Numerador caixa de texto
         // 
         this.numeratorTextBox.Location = new System.Drawing.Point(136, 8);
         this.numeratorTextBox.Name = "numeratorTextBox";
         this.numeratorTextBox.Size = new System.Drawing.Size(120, 20);
         this.numeratorTextBox.TabIndex = 4;
         this.numeratorTextBox.Text = "";
         // 
         // Dominador da label
         // 
         this.denominatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.denominatorLabel.Location = new System.Drawing.Point(8, 50);
         this.denominatorLabel.Name = "denominatorLabel";
         this.denominatorLabel.Size = new System.Drawing.Size(112, 16);
         this.denominatorLabel.TabIndex = 1;
         this.denominatorLabel.Text = "Enter denominator";
         // 
         // Label de saida
         // 
         this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.outputLabel.Location = new System.Drawing.Point(168, 96);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(72, 23);
         this.outputLabel.TabIndex = 2;
         // 
         // Numerador de Label
         // 
         this.numeratorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.numeratorLabel.Location = new System.Drawing.Point(8, 10);
         this.numeratorLabel.Name = "numeratorLabel";
         this.numeratorLabel.Size = new System.Drawing.Size(112, 16);
         this.numeratorLabel.TabIndex = 0;
         this.numeratorLabel.Text = "Enter numerator";
         // 
         // Teste divisao por zero
         //

		//Desenha na tela os botoes
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(264, 133);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.divideButton,
                                                                      this.denominatorTextBox,
                                                                      this.numeratorTextBox,
                                                                      this.numeratorLabel,
                                                                      this.outputLabel,
                                                                      this.denominatorLabel});
         this.Name = "DivideByZeroTest";
         this.Text = "DivideByZero";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
	  /// O ponto de entrada principal da aplicação
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new DivideByZeroTest() );
      } 

      // obtain integers input by user and divide numerator
	  // Obtem os inteiros de entrada do usuario e o divide numerador por denominador
      private void divideButton_Click( 
         object sender, System.EventArgs e )
      {
         outputLabel.Text = "";

		 //	recupera inteiros do usuario e chama o quociente
         try
         {
			// Convert.TpInt32 gera FormatException se argumentos não forem inteiros
            int numerator = Convert.ToInt32( numeratorTextBox.Text );
            int denominator = 
               Convert.ToInt32( denominatorTextBox.Text );

			// divisao gera DivideByZeroException se denominador for 0
            int result = numerator / denominator;

            outputLabel.Text = result.ToString();

         } // Finaliza o try

            // process invalid number format
         catch ( FormatException )
         {
            MessageBox.Show( "You must enter two integers",
               "Invalid Number Format", 
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         }

			// usuario tenta fazer a divisao por 0
         catch ( DivideByZeroException divideByZeroException )
         {
            MessageBox.Show( divideByZeroException.Message,
               "Attempted to Divide by Zero",
               MessageBoxButtons.OK, MessageBoxIcon.Error );
         }

      } // end method divideButton_Click

   } // end class DivideByZeroTest
}

/*
	Esse programa tem como objetivo criar uma interface grafica para gerar botões para se fazer um calculo de divisao
	por 2 numeros. Esse programa possui o tratemento de excessao caso os numero de entrada entrem de maneira indevida,
	exemplo, o usuario tenta entra com uma letra no lugar do numero ou se ele tenta entra com o digito 0 no lugar do numerador.
	Com isso ele possui um metodo para tratar execessões de divideByZeroException e formatException caso os valores sejam
	entrados de forma errada. Esse programa ao final nos mostra o resultado da divisao dos dois numeros e em seguida ele
	reescreve o metodo Dispose para poder fazer liberação da memoria utilizada.
*/
