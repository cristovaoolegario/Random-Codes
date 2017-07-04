// Fig. 12.26: RadioButtonsTest.cs
// Usando RadioButtons para definir as opcoes de caixa de mensagem.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace RadioButtonsTest  
{
   /// <summary> 
   /// o formul·rio contÈm muitos RadioButtons- o usu·rio escolhe um 
   /// de cada grupo para definir uma caixa de mensagem customizada
   /// </summary>
   public class RadioButtonsTest : System.Windows.Forms.Form
   {
      private System.Windows.Forms.Label promptLabel;
      private System.Windows.Forms.Label displayLabel;
      private System.Windows.Forms.Button displayButton;

      private System.Windows.Forms.RadioButton questionButton;
      private System.Windows.Forms.RadioButton informationButton;
      private System.Windows.Forms.RadioButton exclamationButton;
      private System.Windows.Forms.RadioButton errorButton;
      private System.Windows.Forms.RadioButton retryCancelButton;
      private System.Windows.Forms.RadioButton yesNoButton;
      private System.Windows.Forms.RadioButton yesNoCancelButton;
      private System.Windows.Forms.RadioButton okCancelButton;
      private System.Windows.Forms.RadioButton okButton;
      private System.Windows.Forms.RadioButton
         abortRetryIgnoreButton;

      private System.Windows.Forms.GroupBox iconTypeGroupBox;
      private System.Windows.Forms.GroupBox buttonTypeGroupBox;

      private MessageBoxIcon iconType = MessageBoxIcon.Error;
      private MessageBoxButtons buttonType = 
         MessageBoxButtons.OK;
      
      /// <summary>
      /// Variavel de designer requerida
      /// </summary>
      private System.ComponentModel.Container components = null;

      // // construtor padr√£o
      public RadioButtonsTest()
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
         this.informationButton = 
            new System.Windows.Forms.RadioButton();
         this.buttonTypeGroupBox = 
            new System.Windows.Forms.GroupBox();
         this.retryCancelButton = 
            new System.Windows.Forms.RadioButton();
         this.yesNoButton = 
            new System.Windows.Forms.RadioButton();
         this.yesNoCancelButton = 
            new System.Windows.Forms.RadioButton();
         this.abortRetryIgnoreButton = 
            new System.Windows.Forms.RadioButton();
         this.okCancelButton = 
            new System.Windows.Forms.RadioButton();
         this.okButton = 
            new System.Windows.Forms.RadioButton();
         this.iconTypeGroupBox = new System.Windows.Forms.GroupBox();
         this.questionButton = 
            new System.Windows.Forms.RadioButton();
         this.exclamationButton = 
            new System.Windows.Forms.RadioButton();
         this.errorButton = 
            new System.Windows.Forms.RadioButton();
         this.displayLabel = new System.Windows.Forms.Label();
         this.displayButton = 
            new System.Windows.Forms.Button();
         this.promptLabel = new System.Windows.Forms.Label();
         this.buttonTypeGroupBox.SuspendLayout();
         this.iconTypeGroupBox.SuspendLayout();
         this.SuspendLayout();

         // 
         // informationButton
         // 
         this.informationButton.Location = 
            new System.Drawing.Point( 16, 104 );
         this.informationButton.Name = "informationButton";
         this.informationButton.Size = 
            new System.Drawing.Size( 100, 23 );
         this.informationButton.TabIndex = 4;
         this.informationButton.Text = "Information";
         this.informationButton.CheckedChanged += 
            new System.EventHandler(
            this.iconType_CheckedChanged );

         // 
         // buttonTypeGroupBox
         // 
         this.buttonTypeGroupBox.Controls.AddRange( 
            new System.Windows.Forms.Control[] {
               this.retryCancelButton,
               this.yesNoButton,
               this.yesNoCancelButton,
               this.abortRetryIgnoreButton,
               this.okCancelButton,
               this.okButton } );
         this.buttonTypeGroupBox.Location = 
            new System.Drawing.Point( 16, 56 );
         this.buttonTypeGroupBox.Name = "buttonTypeGroupBox";
         this.buttonTypeGroupBox.Size = 
            new System.Drawing.Size( 152, 272 );
         this.buttonTypeGroupBox.TabIndex = 0;
         this.buttonTypeGroupBox.TabStop = false;
         this.buttonTypeGroupBox.Text = "Button Type";

         // 
         // retryCancelButton
         // 
         this.retryCancelButton.Location = 
            new System.Drawing.Point( 16, 224 );
         this.retryCancelButton.Name = "retryCancelButton";
         this.retryCancelButton.Size = 
            new System.Drawing.Size( 100, 23 );
         this.retryCancelButton.TabIndex = 4;
         this.retryCancelButton.Text = "RetryCancel";

         // all radio buttons for button types are registered
         // to buttonType_CheckedChanged event handler
         this.retryCancelButton.CheckedChanged += 
            new System.EventHandler(
            this.buttonType_CheckedChanged );

         // 
         // yesNoButton
         // 
         this.yesNoButton.Location = new System.Drawing.Point( 16, 184 );
         this.yesNoButton.Name = "yesNoButton";
         this.yesNoButton.Size = new System.Drawing.Size( 100, 23 );
         this.yesNoButton.TabIndex = 0;
         this.yesNoButton.Text = "YesNo";
         this.yesNoButton.CheckedChanged += 
            new System.EventHandler(
            this.buttonType_CheckedChanged );

         // 
         // yesNoCancelButton
         // 
         this.yesNoCancelButton.Location = 
            new System.Drawing.Point( 16, 144 );
         this.yesNoCancelButton.Name = "yesNoCancelButton";
         this.yesNoCancelButton.Size = 
            new System.Drawing.Size( 100, 23 );
         this.yesNoCancelButton.TabIndex = 3;
         this.yesNoCancelButton.Text = "YesNoCancel";
         this.yesNoCancelButton.CheckedChanged += 
            new System.EventHandler(
            this.buttonType_CheckedChanged );

         // 
         // abortRetryIgnoreButton
         // 
         this.abortRetryIgnoreButton.Location = 
            new System.Drawing.Point( 16, 104 );
         this.abortRetryIgnoreButton.Name = 
            "abortRetryIgnoreButton";
         this.abortRetryIgnoreButton.Size = 
            new System.Drawing.Size( 120, 23 );
         this.abortRetryIgnoreButton.TabIndex = 2;
         this.abortRetryIgnoreButton.Text = "AbortRetryIgnore";
         this.abortRetryIgnoreButton.CheckedChanged += 
            new System.EventHandler(
            this.buttonType_CheckedChanged );

         // 
         // okCancelButton
         // 
         this.okCancelButton.Location = 
            new System.Drawing.Point( 16, 64 );
         this.okCancelButton.Name = "okCancelButton";
         this.okCancelButton.Size = 
            new System.Drawing.Size( 100, 23 );
         this.okCancelButton.TabIndex = 1;
         this.okCancelButton.Text = "OKCancel";
         this.okCancelButton.CheckedChanged += 
            new System.EventHandler(
            this.buttonType_CheckedChanged );

         // 
         // okButton
         // 
         this.okButton.Checked = true;
         this.okButton.Location = 
            new System.Drawing.Point( 16, 24 );
         this.okButton.Name = "okButton";
         this.okButton.Size = 
            new System.Drawing.Size( 100, 23 );
         this.okButton.TabIndex = 0;
         this.okButton.TabStop = true;
         this.okButton.Text = "OK";
         this.okButton.CheckedChanged += 
            new System.EventHandler(
            this.buttonType_CheckedChanged );

         // 
         // iconTypeGroupBox
         // 
         this.iconTypeGroupBox.Controls.AddRange(
            new System.Windows.Forms.Control[] {
               this.questionButton,
               this.informationButton,
               this.exclamationButton,
               this.errorButton } );
         this.iconTypeGroupBox.Location = 
            new System.Drawing.Point( 200, 56 );
         this.iconTypeGroupBox.Name = "iconTypeGroupBox";
         this.iconTypeGroupBox.Size = 
            new System.Drawing.Size( 136, 176 );
         this.iconTypeGroupBox.TabIndex = 1;
         this.iconTypeGroupBox.TabStop = false;
         this.iconTypeGroupBox.Text = "Icon";

         // 
         // questionButton
         // 
         this.questionButton.Location = 
            new System.Drawing.Point( 16, 144 );
         this.questionButton.Name = "questionButton";
         this.questionButton.Size = 
            new System.Drawing.Size( 100, 23 );
         this.questionButton.TabIndex = 0;
         this.questionButton.Text = "Question";

         // all radio buttons for icon types are registered
         // to iconType_CheckedChanged event handler
         this.questionButton.CheckedChanged += 
            new System.EventHandler(
            this.iconType_CheckedChanged );

         // 
         // exclamationButton
         // 
         this.exclamationButton.Location = 
            new System.Drawing.Point( 16, 64 );
         this.exclamationButton.Name = "exclamationButton";
         this.exclamationButton.Size = 
            new System.Drawing.Size( 104, 23 );
         this.exclamationButton.TabIndex = 2;
         this.exclamationButton.Text = "Exclamation";
         this.exclamationButton.CheckedChanged += 
            new System.EventHandler(
            this.iconType_CheckedChanged );

         // 
         // errorButton
         // 
         this.errorButton.Location = 
            new System.Drawing.Point( 16, 24 );
         this.errorButton.Name = "errorButton";
         this.errorButton.Size = 
            new System.Drawing.Size( 100, 23 );
         this.errorButton.TabIndex = 1;
         this.errorButton.Text = "Error";
         this.errorButton.CheckedChanged += 
            new System.EventHandler(
            this.iconType_CheckedChanged );

         // 
         // displayLabel
         // 
         this.displayLabel.Location = 
            new System.Drawing.Point( 200, 304 );
         this.displayLabel.Name = "displayLabel";
         this.displayLabel.Size = 
            new System.Drawing.Size( 136, 24 );
         this.displayLabel.TabIndex = 4;

         // 
         // displayButton
         // 
         this.displayButton.Location = 
            new System.Drawing.Point( 200, 240 );
         this.displayButton.Name = "displayButton";
         this.displayButton.Size = 
            new System.Drawing.Size( 136, 48 );
         this.displayButton.TabIndex = 3;
         this.displayButton.Text = "Display";
         this.displayButton.Click += 
            new System.EventHandler( this.displayButton_Click );

         // 
         // promptLabel
         // 
         this.promptLabel.Font = 
            new System.Drawing.Font(
            "Microsoft Sans Serif", 9.5F, 
            System.Drawing.FontStyle.Regular, 
            System.Drawing.GraphicsUnit.Point, 
            ( ( System.Byte )( 0 ) ) );
         this.promptLabel.Location = 
            new System.Drawing.Point( 8, 16 );
         this.promptLabel.Name = "promptLabel";
         this.promptLabel.Size = 
            new System.Drawing.Size( 344, 24 );
         this.promptLabel.TabIndex = 5;
         this.promptLabel.Text = "Choose the type of " +
            "MessageBox you would like to display!";

         // 
         // RadioButtonsTest
         // 
         this.AutoScaleBaseSize = 
            new System.Drawing.Size( 5, 13 );
         this.ClientSize = 
            new System.Drawing.Size( 360, 341 );
         this.Controls.AddRange(
            new System.Windows.Forms.Control[] {
               this.promptLabel,
               this.displayLabel,
               this.displayButton,
               this.iconTypeGroupBox,
               this.buttonTypeGroupBox } );
         this.Name = "RadioButtonsTest";
         this.Text = "Demonstrating RadioButtons";
         this.buttonTypeGroupBox.ResumeLayout( false );
         this.iconTypeGroupBox.ResumeLayout( false );
         this.ResumeLayout( false );

      } // end method InitializeComponent

		#endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new RadioButtonsTest() );
      }

      // muda o bot√£o baseado na op√ß√£o escolhida pelo sender
      private void buttonType_CheckedChanged(
         object sender, System.EventArgs e )
      {
         if ( sender == okButton ) // mostra bot√£o de OK
            buttonType = MessageBoxButtons.OK;

         // mostra os botoes OK e Cancel 
         else if ( sender == okCancelButton )
            buttonType = MessageBoxButtons.OKCancel;

         // Mostra os botoes Abort, Retry e Ignore 
         else if ( sender == abortRetryIgnoreButton )
            buttonType = MessageBoxButtons.AbortRetryIgnore;

         // mostra os botoes Yes, No e Cancel 
         else if ( sender == yesNoCancelButton )
            buttonType = MessageBoxButtons.YesNoCancel;

         // Mostra os botoes Yes e No buttons
         else if ( sender == yesNoButton )
            buttonType = MessageBoxButtons.YesNo;

         // Apenas uma opÁ„o sobrando-- mostra os  
         // bot√µes Retry e Cancel 
         else
            buttonType = MessageBoxButtons.RetryCancel;

      } // fim do metodo  buttonType_CheckedChanged

      // muda o icone baseda na opcao escolhida pelo sender
      private void iconType_CheckedChanged(
         object sender, System.EventArgs e )
      {
         if ( sender == errorButton ) // Mostra o icone de erro
            iconType = MessageBoxIcon.Error;

         // mostra o ponto de exclamacao
         else if ( sender == exclamationButton )
            iconType = MessageBoxIcon.Exclamation;

         // mostra o icone de informa
         else if ( sender == informationButton ) 
            iconType = MessageBoxIcon.Information;

         else // apenas uma opcao restante--mostra a interrogacao
            iconType = MessageBoxIcon.Question;

      } // fim do metodo iconType_CheckedChanged

      // mostra a  MessageBox e botao que o usuario pressionou 
      protected void displayButton_Click( 
         object sender, System.EventArgs e )
      {
         DialogResult result = 
            MessageBox.Show( "This is Your Custom MessageBox.", 
            "Custom MessageBox", buttonType, iconType, 0, 0 );

         // checar dialog  para obter um resultado e mostrar o resutado na label
         switch ( result )
         {
            case DialogResult.OK: 
               displayLabel.Text = "OK was pressed."; 
               break;

            case DialogResult.Cancel: 
               displayLabel.Text = "Cancel was pressed."; 
               break;

            case DialogResult.Abort: 
               displayLabel.Text = "Abort was pressed."; 
               break;

            case DialogResult.Retry: 
               displayLabel.Text = "Retry was pressed."; 
               break;

            case DialogResult.Ignore: 
               displayLabel.Text = "Ignore was pressed."; 
               break;

            case DialogResult.Yes: 
               displayLabel.Text = "Yes was pressed."; 
               break;

            case DialogResult.No: 
               displayLabel.Text = "No was pressed."; 
               break;

         } // fim switch

      } // fim metodo displayButton_Click

   } // fim da class RadioButtonsTest

} // fim do namespace RadioButtonsTest

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
