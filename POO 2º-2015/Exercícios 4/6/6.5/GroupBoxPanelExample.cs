// Fig. 12.22: GroupBoxPanelExample.cs                             
// Usando GroupBoxes e Panels para mostrar botões.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

// namespace que contém a class
// para nossa demostração de groupbox e panel
namespace GroupBoxPanelExample
{
   /// <summary>
   /// Formulário para mostrar um groupbox versus um panel
   /// </summary>
   public class GroupBoxPanelExample : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Button hiButton;
      private System.Windows.Forms.Button byeButton;
      private System.Windows.Forms.Button leftButton;
      private System.Windows.Forms.Button rightButton;

      private System.Windows.Forms.GroupBox mainGroupBox;
      private System.Windows.Forms.Label messageLabel;
      private System.Windows.Forms.Panel mainPanel;

      private System.ComponentModel.Container components = null;

      // construtor padrão
      public GroupBoxPanelExample()
      {
         InitializeComponent();
      }

      /// <summary>
      /// Limpar todos os recursos a ser utilizado.
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
         this.messageLabel = new System.Windows.Forms.Label();
         this.byeButton = new System.Windows.Forms.Button();
         this.mainGroupBox = new System.Windows.Forms.GroupBox();
         this.hiButton = new System.Windows.Forms.Button();
         this.mainPanel = new System.Windows.Forms.Panel();
         this.rightButton = new System.Windows.Forms.Button();
         this.leftButton = new System.Windows.Forms.Button();
         this.mainGroupBox.SuspendLayout();
         this.mainPanel.SuspendLayout();
         this.SuspendLayout();

         // 
         // messageLabel
         // 
         this.messageLabel.Location = 
            new System.Drawing.Point( 24, 144 );
         this.messageLabel.Name = "messageLabel";
         this.messageLabel.Size = 
            new System.Drawing.Size( 176, 32 );
         this.messageLabel.TabIndex = 2;

         // 
         // byeButton
         // 
         this.byeButton.Location = 
            new System.Drawing.Point( 96, 48 );
         this.byeButton.Name = "byeButton";
         this.byeButton.Size = 
            new System.Drawing.Size( 72, 32 );
         this.byeButton.TabIndex = 0;
         this.byeButton.Text = "Bye";

         // register event handler
         this.byeButton.Click += 
            new System.EventHandler( this.byeButton_Click );

         // 
         // mainGroupBox
         // 

         // add controls to mainGroupBox
         this.mainGroupBox.Controls.AddRange(
            new System.Windows.Forms.Control[] {
            this.byeButton,
            this.hiButton } );
         this.mainGroupBox.Location = 
            new System.Drawing.Point( 24, 24 );
         this.mainGroupBox.Name = "mainGroupBox";
         this.mainGroupBox.Size = 
            new System.Drawing.Size( 176, 104 );
         this.mainGroupBox.TabIndex = 0;
         this.mainGroupBox.TabStop = false;
         this.mainGroupBox.Text = "Main GroupBox";

         // 
         // hiButton
         // 
         this.hiButton.Location = 
            new System.Drawing.Point( 8, 48 );
         this.hiButton.Name = "hiButton";
         this.hiButton.Size = 
            new System.Drawing.Size( 72, 32 );
         this.hiButton.TabIndex = 0;
         this.hiButton.Text = "Hi";
         this.hiButton.Click += new System.EventHandler( 
            this.hiButton_Click );

         // 
         // mainPanel
         // 
         this.mainPanel.AutoScroll = true;
         this.mainPanel.BorderStyle = 
            System.Windows.Forms.BorderStyle.FixedSingle;

         // add controls to mainPanel
         this.mainPanel.Controls.AddRange(
            new System.Windows.Forms.Control[] {
            this.rightButton,
            this.leftButton } );
         this.mainPanel.Location = 
            new System.Drawing.Point( 24, 192 );
         this.mainPanel.Name = "mainPanel";
         this.mainPanel.Size = 
            new System.Drawing.Size( 176, 112 );
         this.mainPanel.TabIndex = 1;

         // 
         // rightButton
         // 
         this.rightButton.Location = 
            new System.Drawing.Point( 264, 40 );
         this.rightButton.Name = "rightButton";
         this.rightButton.Size = 
            new System.Drawing.Size( 80, 40 );
         this.rightButton.TabIndex = 0;
         this.rightButton.Text = "Far Right";
         this.rightButton.Click += new System.EventHandler( 
            this.rightButton_Click );

         // 
         // leftButton
         // 
         this.leftButton.Location = 
            new System.Drawing.Point( 8, 40 );
         this.leftButton.Name = "leftButton";
         this.leftButton.Size = 
            new System.Drawing.Size( 80, 40 );
         this.leftButton.TabIndex = 0;
         this.leftButton.Text = "Far Left";
         this.leftButton.Click += 
            new System.EventHandler( this.leftButton_Click );

         // 
         // GroupBoxPanelExample
         // 
         this.AutoScaleBaseSize = 
            new System.Drawing.Size( 5, 13 );
         this.ClientSize = 
            new System.Drawing.Size( 224, 317 );
         this.Controls.AddRange( 
            new System.Windows.Forms.Control[] {
               this.messageLabel,
               this.mainPanel,
               this.mainGroupBox } );
         this.Name = "GroupBoxPanelExample";
         this.Text = "GroupBoxPanelExample";
         this.mainGroupBox.ResumeLayout( false );
         this.mainPanel.ResumeLayout( false );
         this.ResumeLayout( false );

      } // end method InitializeComponent

      // end region beginning on line 53
      #endregion

      /// <summary>
      /// O principal ponto de partida para o aplicativo.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new GroupBoxPanelExample() );
      }

      // Manipuladores de eventos para mudar messageLabel

      // Manipulador de evento para hi button
      private void hiButton_Click( 
         object sender, System.EventArgs e )
      {
         messageLabel.Text= "Hi pressed";
      }

      // Manipulador de evento para bye button
      private void byeButton_Click( 
         object sender, System.EventArgs e )
      {
         messageLabel.Text = "Bye pressed";
      }

      // Manipulador de evento para far left button
      private void leftButton_Click( 
         object sender, System.EventArgs e )
      {
         messageLabel.Text = "Far left pressed";
      }

      // Manipulador de evento para far right button
      private void rightButton_Click( 
         object sender, System.EventArgs e )
      {
         messageLabel.Text = "Far right pressed";
      }

   } // fim da classe GroupBoxPanelExample

} // fim do namespace GroupBoxPanelExample

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
