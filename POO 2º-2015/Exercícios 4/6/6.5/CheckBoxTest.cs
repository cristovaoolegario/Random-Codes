// Fig. 12.24: CheckBoxTest.cs
// Usando CheckBoxes parar alternar entre o italico e o negrito.

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CheckBoxTest
{
    /// <summary>
    /// o formulário contém checkboxes para permitir 
    /// o usuário modificar um texto exemplo 
    /// </summary>
    public class CheckBoxTest : System.Windows.Forms.Form
    {
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;

        private System.Windows.Forms.Label outputLabel;

        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.Container components = null;

        // construtor padrão
        public CheckBoxTest()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limpar todos os recursos a ser utilizado.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boldCheckBox =
               new System.Windows.Forms.CheckBox();
            this.outputLabel =
               new System.Windows.Forms.Label();
            this.italicCheckBox =
               new System.Windows.Forms.CheckBox();
            this.SuspendLayout();

            // 
            // boldCheckBox
            // 
            this.boldCheckBox.Location =
               new System.Drawing.Point(72, 56);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size =
               new System.Drawing.Size(48, 24);
            this.boldCheckBox.TabIndex = 1;
            this.boldCheckBox.Text = "Bold";

            // register event handlers
            this.boldCheckBox.CheckedChanged +=
               new System.EventHandler(
               this.boldCheckBox_CheckedChanged);

            // 
            // outputLabel
            // 
            this.outputLabel.Location =
               new System.Drawing.Point(64, 24);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size =
               new System.Drawing.Size(152, 16);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text =
               "Watch the font style change";

            // 
            // italicCheckBox
            // 
            this.italicCheckBox.Location =
               new System.Drawing.Point(160, 56);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size =
               new System.Drawing.Size(48, 24);
            this.italicCheckBox.TabIndex = 1;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.CheckedChanged +=
               new System.EventHandler(
               this.italicCheckBox_CheckedChanged);

            // 
            // CheckBoxTest
            // 
            this.AutoScaleBaseSize =
               new System.Drawing.Size(5, 13);
            this.ClientSize =
               new System.Drawing.Size(264, 109);
            this.Controls.AddRange(
               new System.Windows.Forms.Control[] {
               this.italicCheckBox,
               this.boldCheckBox,
               this.outputLabel });
            this.Name = "CheckBoxTest";
            this.Text = "CheckBoxTest";
            this.ResumeLayout(false);

        } // end method InitializeComponent

        // end region beginning on line 50
        #endregion

        /// <summary>
        /// O principal ponto de partida para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new CheckBoxTest());
        }

        // Deixar o texto em negrito se não estiver em negrito, 
        // se já estiver em negrito deixa-lo normal 
        private void boldCheckBox_CheckedChanged(
           object sender, System.EventArgs e)
        {
            outputLabel.Font =
               new Font(outputLabel.Font.Name,
               outputLabel.Font.Size,
               outputLabel.Font.Style ^ FontStyle.Bold);
        }

        // Deixar o texto em italico se não estiver em italico, 
        // se já estiver em italico deixa-lo normal
        private void italicCheckBox_CheckedChanged(
           object sender, System.EventArgs e)
        {
            outputLabel.Font =
               new Font(outputLabel.Font.Name,
               outputLabel.Font.Size,
               outputLabel.Font.Style ^ FontStyle.Italic);
        }

    } // fim da class CheckBoxTest

} // fim do namespace CheckBoxTest

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
