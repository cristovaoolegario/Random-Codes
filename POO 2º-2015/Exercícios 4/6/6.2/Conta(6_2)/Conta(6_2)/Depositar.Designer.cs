namespace Conta_6_2_
{
    partial class Depositar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depositar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_numconta = new System.Windows.Forms.TextBox();
            this.tb_deposito = new System.Windows.Forms.TextBox();
            this.btn_deposito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número da conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deposito";
            // 
            // tb_numconta
            // 
            this.tb_numconta.Location = new System.Drawing.Point(132, 33);
            this.tb_numconta.Name = "tb_numconta";
            this.tb_numconta.Size = new System.Drawing.Size(34, 20);
            this.tb_numconta.TabIndex = 2;
            // 
            // tb_deposito
            // 
            this.tb_deposito.Location = new System.Drawing.Point(106, 76);
            this.tb_deposito.Name = "tb_deposito";
            this.tb_deposito.Size = new System.Drawing.Size(60, 20);
            this.tb_deposito.TabIndex = 3;
            // 
            // btn_deposito
            // 
            this.btn_deposito.Location = new System.Drawing.Point(63, 119);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(75, 23);
            this.btn_deposito.TabIndex = 4;
            this.btn_deposito.Text = "Depositar";
            this.btn_deposito.UseVisualStyleBackColor = true;
            this.btn_deposito.Click += new System.EventHandler(this.btn_deposito_Click);
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 165);
            this.Controls.Add(this.btn_deposito);
            this.Controls.Add(this.tb_deposito);
            this.Controls.Add(this.tb_numconta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Depositar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_numconta;
        private System.Windows.Forms.TextBox tb_deposito;
        private System.Windows.Forms.Button btn_deposito;
    }
}