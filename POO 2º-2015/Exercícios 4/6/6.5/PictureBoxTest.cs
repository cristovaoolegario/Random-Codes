// Fig. 12.28: PictureBoxTest.cs
// Usando PictureBox para mostrar imagens.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace PictureBoxTest
{
   /// <summary>
   /// formulário para mostrar diferentes imagens quando clickado
   /// </summary>
   public class PictureBoxTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.PictureBox imagePictureBox;
      private System.Windows.Forms.Label promptLabel;

      private int imageNum = -1;

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      // construtor padrÃ£o
      public PictureBoxTest()
      {
         InitializeComponent();
      }

      /// <summary>
      /// Clean up any resources being used.
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
         this.promptLabel = new System.Windows.Forms.Label();
         this.imagePictureBox = new System.Windows.Forms.PictureBox();
         this.SuspendLayout();
         // 
         // promptLabel
         // 
         this.promptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.promptLabel.Location = new System.Drawing.Point(22, 8);
         this.promptLabel.Name = "promptLabel";
         this.promptLabel.Size = new System.Drawing.Size(124, 56);
         this.promptLabel.TabIndex = 0;
         this.promptLabel.Text = "Click On PictureBox to View Images";
         this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // imagePictureBox
         // 
         this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.imagePictureBox.Location = new System.Drawing.Point(34, 72);
         this.imagePictureBox.Name = "imagePictureBox";
         this.imagePictureBox.Size = new System.Drawing.Size(100, 100);
         this.imagePictureBox.TabIndex = 1;
         this.imagePictureBox.TabStop = false;

         // register event handler
         this.imagePictureBox.Click += 
            new System.EventHandler(
            this.imagePictureBox_Click );
         // 
         // PictureBoxTest
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(168, 189);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.imagePictureBox,
                                                                      this.promptLabel});
         this.Name = "PictureBoxTest";
         this.Text = "PictureBoxTest";
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// Ponto de partida da aplicação
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new PictureBoxTest() );
      }

      // muda a imagem sempre que a PictureBox é clickada
      private void imagePictureBox_Click( 
         object sender, System.EventArgs e )
      {
         imageNum = ( imageNum + 1 ) % 3; // imageNum de 0 a 2
      
         // cria Image object do arquivo, mostra na PictureBox
         imagePictureBox.Image = Image.FromFile( 
            Directory.GetCurrentDirectory() + "\\images\\image" + 
            imageNum + ".bmp" );
      }

   } // fim da class PictureBoxTest

} // fim da namespace PictureBoxTest

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
