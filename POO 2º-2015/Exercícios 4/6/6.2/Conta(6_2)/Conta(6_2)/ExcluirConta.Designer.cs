namespace Conta_6_2_
{
    partial class ExcluirConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirConta));
            this.lb_display = new System.Windows.Forms.Label();
            this.tb_numconta = new System.Windows.Forms.TextBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_display
            // 
            this.lb_display.AutoSize = true;
            this.lb_display.Location = new System.Drawing.Point(12, 26);
            this.lb_display.Name = "lb_display";
            this.lb_display.Size = new System.Drawing.Size(126, 13);
            this.lb_display.TabIndex = 0;
            this.lb_display.Text = "Digite o número da conta";
            // 
            // tb_numconta
            // 
            this.tb_numconta.Location = new System.Drawing.Point(37, 56);
            this.tb_numconta.Name = "tb_numconta";
            this.tb_numconta.Size = new System.Drawing.Size(68, 20);
            this.tb_numconta.TabIndex = 1;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(37, 93);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(68, 22);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // ExcluirConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 142);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.tb_numconta);
            this.Controls.Add(this.lb_display);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExcluirConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcluirConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_display;
        private System.Windows.Forms.TextBox tb_numconta;
        private System.Windows.Forms.Button btn_excluir;
    }
}