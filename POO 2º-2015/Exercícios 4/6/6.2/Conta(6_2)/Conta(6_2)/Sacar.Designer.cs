namespace Conta_6_2_
{
    partial class Sacar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sacar));
            this.btn_saque = new System.Windows.Forms.Button();
            this.tb_saque = new System.Windows.Forms.TextBox();
            this.tb_numconta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_saque
            // 
            this.btn_saque.Location = new System.Drawing.Point(48, 104);
            this.btn_saque.Name = "btn_saque";
            this.btn_saque.Size = new System.Drawing.Size(75, 23);
            this.btn_saque.TabIndex = 9;
            this.btn_saque.Text = "Sacar";
            this.btn_saque.UseVisualStyleBackColor = true;
            this.btn_saque.Click += new System.EventHandler(this.btn_saque_Click);
            // 
            // tb_saque
            // 
            this.tb_saque.Location = new System.Drawing.Point(103, 59);
            this.tb_saque.Name = "tb_saque";
            this.tb_saque.Size = new System.Drawing.Size(60, 20);
            this.tb_saque.TabIndex = 8;
            // 
            // tb_numconta
            // 
            this.tb_numconta.Location = new System.Drawing.Point(129, 33);
            this.tb_numconta.Name = "tb_numconta";
            this.tb_numconta.Size = new System.Drawing.Size(34, 20);
            this.tb_numconta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sacar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número da conta";
            // 
            // Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 149);
            this.Controls.Add(this.btn_saque);
            this.Controls.Add(this.tb_saque);
            this.Controls.Add(this.tb_numconta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sacar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saque;
        private System.Windows.Forms.TextBox tb_saque;
        private System.Windows.Forms.TextBox tb_numconta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}