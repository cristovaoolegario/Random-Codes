// Fig 12.30: Painter.cs
// Usando o mouse para desenhar uma forma

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Painter
{
   /// <summary>
   /// creates a form as a drawing surface
   /// </summary>
   public class Painter : System.Windows.Forms.Form
   {
      bool shouldPaint = false; // se pintar

      /// <summary>
      /// Variavel de designer requerida
      /// </summary>
      private System.ComponentModel.Container components = null;

      // construtor padrão
      public Painter()
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
         // 
         // Painter
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(144, 133);
         this.Name = "Painter";
         this.Text = "Painter";

         // register event handlers
         this.MouseDown += 
            new System.Windows.Forms.MouseEventHandler(
            this.Painter_MouseDown );
         
         this.MouseUp += 
            new System.Windows.Forms.MouseEventHandler(
            this.Painter_MouseUp );
         
         this.MouseMove += 
            new System.Windows.Forms.MouseEventHandler(
            this.Painter_MouseMove );

      } // end method InitializeComponent

		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new Painter() );
      }

      // deve pintar depois do botão do mouse ter sido pressionado
      private void Painter_MouseDown( 
         object sender, System.Windows.Forms.MouseEventArgs e )
      {
         shouldPaint = true;
      }

      // parar de pintar depois que o botão mouse for solto
      private void Painter_MouseUp( 
         object sender, System.Windows.Forms.MouseEventArgs e )
      {
         shouldPaint = false;
      }

      // desenhar um circulo sempre que o botão do mouse  
      // movimentar (e o mouse é clickado)
      protected void Painter_MouseMove( 
         object sender, System.Windows.Forms.MouseEventArgs e )
      {
         if ( shouldPaint )
         {
            Graphics graphics = CreateGraphics();
            graphics.FillEllipse( 
               new SolidBrush( Color.BlueViolet ), 
               e.X, e.Y, 4, 4 );
         }

      } // fim Painter_MouseMove

   } // fim da  class Painter

} // fim do namespace Painter

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
