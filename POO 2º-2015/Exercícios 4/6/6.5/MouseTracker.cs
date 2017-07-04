// Fig. 12.xx: MouseTracker.cs
// Demonstração de eventos com  mouse (clicks, pressinar e movimentos). 

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MouseTracker
{
   /// <summary>
   /// Summary description for Form1.
   /// </summary>
   public class MouseTracker : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label outputLabel;
      /// <summary>
      /// Variavel de designer requerida
      /// </summary>
      private System.ComponentModel.Container components = null;

      public MouseTracker()
      {
         //
         // requerido por Windows Form Designer suporte
         //
         InitializeComponent();

         //
         // TODO: adcionar qualquer código de construtor depois da chamada de InitializeComponent 
         //
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
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
         this.outputLabel = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // outputLabel
         // 
         this.outputLabel.Location = new System.Drawing.Point(16, 256);
         this.outputLabel.Name = "outputLabel";
         this.outputLabel.Size = new System.Drawing.Size(184, 23);
         this.outputLabel.TabIndex = 0;
         // 
         // MouseTracker
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
         this.ClientSize = new System.Drawing.Size(544, 285);
         this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                      this.outputLabel});
         this.Name = "MouseTracker";
         this.Text = "MouseTracker";
         this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseTracker_MouseDown);
         this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseTracker_MouseUp);
         this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseTracker_MouseMove);
         this.MouseEnter += new System.EventHandler(this.MouseTracker_MouseEnter);
         this.MouseLeave += new System.EventHandler(this.MouseTracker_MouseLeave);
         this.ResumeLayout(false);

      }
		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new MouseTracker() );
      }

      // manipulador de evento quando o mouse é pressionado e depois solto
      protected void MouseTracker_MouseUp( object sender, 
         System.Windows.Forms.MouseEventArgs e )
      {
         outputLabel.Text = "Pressed at [" + e.X + "," + e.Y + "]";
      }

      // manipulador de evento quando o mouse move
      protected void MouseTracker_MouseMove( object sender, 
         System.Windows.Forms.MouseEventArgs e )
      {
         outputLabel.Text = "Moved at [" + e.X + "," + e.Y + "]";
      }

      // manipulador de evento quando o mouse sai do formulário
      protected void MouseTracker_MouseLeave( object sender, 
         System.EventArgs e )
      {
         outputLabel.Text = "Mouse outside Window";
      }

      // manipulador de evento quando o mouse entra no formulário
      protected void MouseTracker_MouseEnter( object sender, 
         System.EventArgs e )
      {
         outputLabel.Text = "Mouse in Window";
      }

      // manipulador de evento quando o mouse é clickado
      protected void MouseTracker_MouseDown( object sender, 
         System.Windows.Forms.MouseEventArgs e )
      {
         outputLabel.Text = "Clicked at [" + e.X + "," + e.Y + "]";
      }

   } // fim da class class MouseTracker
}

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
