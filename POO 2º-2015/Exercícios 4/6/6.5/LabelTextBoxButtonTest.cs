// Fig. 12.xx: LabelTextBoxButtonTest.cs
// Usando uma TextBox, Label e Botão para mostrar 
// o texto escondido numa caixa de senha.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

// namespace contém nosso formulário para mostrar os texto escondido 
namespace LabelTextBoxButtonTest
{
   /// <summary>
   /// formulário que cria uma textbox para senha e 
   /// uma label para mostrar o conteudo da textbox 
   /// </summary>
   public class LabelTextBoxButtonTest : 
      System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button displayPasswordButton;
      private System.Windows.Forms.Label displayPasswordLabel;
      private System.Windows.Forms.TextBox inputPasswordTextBox;

      /// <summary>
      /// Variavel de designer requerida
      /// </summary>
      private System.ComponentModel.Container components = null;

      // construtor padrão
      public LabelTextBoxButtonTest()
      {
         InitializeComponent();
      }

      /// <summary>
      /// Limpar todos os recursos a ser usados
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
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.displayPasswordButton = 
            new System.Windows.Forms.Button();
         this.displayPasswordLabel = 
            new System.Windows.Forms.Label();
         this.inputPasswordTextBox = 
            new System.Windows.Forms.TextBox();
         this.SuspendLayout();

         // 
         // displayPasswordButton
         // 
         this.displayPasswordButton.Location = 
            new System.Drawing.Point( 96, 96 );
         this.displayPasswordButton.Name = 
            "displayPasswordButton";
         this.displayPasswordButton.TabIndex = 1;
         this.displayPasswordButton.Text = "Show Me";
         this.displayPasswordButton.Click += 
            new System.EventHandler( 
            this.displayPasswordButton_Click );

         // 
         // displayPasswordLabel
         // 
         this.displayPasswordLabel.BorderStyle = 
            System.Windows.Forms.BorderStyle.Fixed3D;
         this.displayPasswordLabel.Location = 
            new System.Drawing.Point( 16, 48 );
         this.displayPasswordLabel.Name = "displayPasswordLabel";
         this.displayPasswordLabel.Size = 
            new System.Drawing.Size( 264, 23 );
         this.displayPasswordLabel.TabIndex = 2;

         // 
         // inputPasswordTextBox
         // 
         this.inputPasswordTextBox.Location = 
            new System.Drawing.Point( 16, 16 );
         this.inputPasswordTextBox.Name = 
            "inputPasswordTextBox";
         this.inputPasswordTextBox.PasswordChar = '*';
         this.inputPasswordTextBox.Size = 
            new System.Drawing.Size( 264, 20 );
         this.inputPasswordTextBox.TabIndex = 0;
         this.inputPasswordTextBox.Text = "";

         // 
         // LabelTextBoxButtonTest
         // 
         this.AutoScaleBaseSize = 
            new System.Drawing.Size( 5, 13 );
         this.ClientSize = 
            new System.Drawing.Size( 292, 133 );
         this.Controls.AddRange( 
            new System.Windows.Forms.Control[] {
            this.displayPasswordLabel,
            this.inputPasswordTextBox,
            this.displayPasswordButton } );
         this.Name = "LabelTextBoxButtonTest";
         this.Text = "LabelTextBoxButtonTest";
         this.ResumeLayout( false );

      } // end method InitializeComponent

      // end collapsable region started on line 53
      #endregion

      /// <summary>
      /// Ponto de partida da aplicação
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new LabelTextBoxButtonTest() );
      }

      // Mostra o que o usuário digitou na label
      protected void displayPasswordButton_Click( 
         object sender, System.EventArgs e )
      {
         // texto não mudou
         displayPasswordLabel.Text = 
            inputPasswordTextBox.Text;
      }

   } // fim da class LabelTextBoxButtonTest

} // fim da namespace LabelTextBoxButtonTest

/*
 **************************************************************************
 * (C) Copyright 2002 by Deitel & Associates, Inc. and Prentice Hall.     *
 * All Rights Reserved.                                                   *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
*/