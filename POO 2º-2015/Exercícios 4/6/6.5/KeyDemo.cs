// Fig. 12.32: KeyDemo.cs       
// Mostra informações das teclas pressionadas

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace KeyDemo
{
   /// <summary>
   /// Formulário para mostrar tecla pressionada 
   /// Possui duas labels
   /// </summary>
   public class KeyDemo : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label charLabel;
      private System.Windows.Forms.Label keyInfoLabel;

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // construtor padrão
      public KeyDemo()
      {
         InitializeComponent();
      }

      /// <summary>
      /// Limpar recursos a ser usados
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
      /// Método requerido para Designer support - não modificar
      /// os componentes desse método com o editor de código
      /// </summary>
      private void InitializeComponent()
      {
         this.charLabel = new System.Windows.Forms.Label();
         this.keyInfoLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // charLabel
         // 
         this.charLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.charLabel.Location = new System.Drawing.Point(8, 8);
         this.charLabel.Name = "charLabel";
         this.charLabel.Size = new System.Drawing.Size(168, 32);
         this.charLabel.TabIndex = 0;
         // 
         // keyInfoLabel
         // 
         this.keyInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
         this.keyInfoLabel.Location = new System.Drawing.Point(8, 56);
         this.keyInfoLabel.Name = "keyInfoLabel";
         this.keyInfoLabel.Size = new System.Drawing.Size(168, 136);
         this.keyInfoLabel.TabIndex = 0;
         // 
         // KeyDemo
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(15, 37);
         this.ClientSize = new System.Drawing.Size(184, 197);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.keyInfoLabel,
                                                                      this.charLabel});
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
         this.Name = "KeyDemo";
         this.Text = "KeyDemo";

         // register event handlers (note different delegates)
         this.KeyDown += 
            new System.Windows.Forms.KeyEventHandler(
            this.KeyDemo_KeyDown );
         
         this.KeyPress += 
            new System.Windows.Forms.KeyPressEventHandler(
            this.KeyDemo_KeyPress );
         
         this.KeyUp += 
            new System.Windows.Forms.KeyEventHandler(
            this.KeyDemo_KeyUp );
         
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new KeyDemo() );
      }

      // mostra o  caracter pressionado usando uma tecla de caracter 
      protected void KeyDemo_KeyPress( 
         object sender, System.Windows.Forms.KeyPressEventArgs e )
      {  
         charLabel.Text = "Key pressed: " + e.KeyChar;
      }

      // Mostrar teclas modificadas, codigos de tecla, key data and valor da tecla
      private void KeyDemo_KeyDown( 
         object sender, System.Windows.Forms.KeyEventArgs e )
      {
         keyInfoLabel.Text = 
            "Alt: " + (e.Alt ? "Yes" : "No") + '\n' +
            "Shift: " + (e.Shift ? "Yes" : "No" ) + '\n' +
            "Ctrl: " + (e.Control ? "Yes" : "No" ) + '\n' + 
            "KeyCode: " + e.KeyCode + '\n' +
            "KeyData: " + e.KeyData + '\n' +
            "KeyValue: " + e.KeyValue;                               
      }
   
      // limpar labels quando a tecla for solta 
      private void KeyDemo_KeyUp( 
         object sender, System.Windows.Forms.KeyEventArgs e )
      {
         keyInfoLabel.Text = "";
         charLabel.Text = "";
      }

   } // end class KeyDemo

} // end namespace KeyDemo

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
