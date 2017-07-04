namespace Conta_6_2_
{
    partial class NovaConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaConta));
            this.lb_displayname = new System.Windows.Forms.Label();
            this.lb_displayage = new System.Windows.Forms.Label();
            this.lb_display_num = new System.Windows.Forms.Label();
            this.lb_numConta = new System.Windows.Forms.Label();
            this.radioBtn_poupanca = new System.Windows.Forms.RadioButton();
            this.radioBtn_investimento = new System.Windows.Forms.RadioButton();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_agencia = new System.Windows.Forms.TextBox();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_display_saldo = new System.Windows.Forms.Label();
            this.tb_saldoini = new System.Windows.Forms.TextBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_displayname
            // 
            this.lb_displayname.AutoSize = true;
            this.lb_displayname.Location = new System.Drawing.Point(21, 26);
            this.lb_displayname.Name = "lb_displayname";
            this.lb_displayname.Size = new System.Drawing.Size(39, 13);
            this.lb_displayname.TabIndex = 0;
            this.lb_displayname.Text = "NOME";
            // 
            // lb_displayage
            // 
            this.lb_displayage.AutoSize = true;
            this.lb_displayage.Location = new System.Drawing.Point(21, 55);
            this.lb_displayage.Name = "lb_displayage";
            this.lb_displayage.Size = new System.Drawing.Size(54, 13);
            this.lb_displayage.TabIndex = 1;
            this.lb_displayage.Text = "AGÊNCIA";
            // 
            // lb_display_num
            // 
            this.lb_display_num.AutoSize = true;
            this.lb_display_num.Location = new System.Drawing.Point(21, 116);
            this.lb_display_num.Name = "lb_display_num";
            this.lb_display_num.Size = new System.Drawing.Size(59, 13);
            this.lb_display_num.TabIndex = 2;
            this.lb_display_num.Text = "Nº CONTA";
            // 
            // lb_numConta
            // 
            this.lb_numConta.AutoSize = true;
            this.lb_numConta.Location = new System.Drawing.Point(94, 116);
            this.lb_numConta.Name = "lb_numConta";
            this.lb_numConta.Size = new System.Drawing.Size(35, 13);
            this.lb_numConta.TabIndex = 3;
            this.lb_numConta.Text = "label4";
            // 
            // radioBtn_poupanca
            // 
            this.radioBtn_poupanca.AutoSize = true;
            this.radioBtn_poupanca.Location = new System.Drawing.Point(24, 142);
            this.radioBtn_poupanca.Name = "radioBtn_poupanca";
            this.radioBtn_poupanca.Size = new System.Drawing.Size(105, 17);
            this.radioBtn_poupanca.TabIndex = 4;
            this.radioBtn_poupanca.TabStop = true;
            this.radioBtn_poupanca.Text = "Conta Poupança";
            this.radioBtn_poupanca.UseVisualStyleBackColor = true;
            // 
            // radioBtn_investimento
            // 
            this.radioBtn_investimento.AutoSize = true;
            this.radioBtn_investimento.Location = new System.Drawing.Point(156, 142);
            this.radioBtn_investimento.Name = "radioBtn_investimento";
            this.radioBtn_investimento.Size = new System.Drawing.Size(116, 17);
            this.radioBtn_investimento.TabIndex = 5;
            this.radioBtn_investimento.TabStop = true;
            this.radioBtn_investimento.Text = "Conta Investimento";
            this.radioBtn_investimento.UseVisualStyleBackColor = true;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(90, 19);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(83, 20);
            this.tb_nome.TabIndex = 6;
            // 
            // tb_agencia
            // 
            this.tb_agencia.Location = new System.Drawing.Point(90, 48);
            this.tb_agencia.Name = "tb_agencia";
            this.tb_agencia.Size = new System.Drawing.Size(81, 20);
            this.tb_agencia.TabIndex = 7;
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Location = new System.Drawing.Point(194, 26);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(35, 13);
            this.lb_data.TabIndex = 8;
            this.lb_data.Text = "label5";
            // 
            // lb_display_saldo
            // 
            this.lb_display_saldo.AutoSize = true;
            this.lb_display_saldo.Location = new System.Drawing.Point(21, 86);
            this.lb_display_saldo.Name = "lb_display_saldo";
            this.lb_display_saldo.Size = new System.Drawing.Size(63, 13);
            this.lb_display_saldo.TabIndex = 9;
            this.lb_display_saldo.Text = "Saldo inicial";
            // 
            // tb_saldoini
            // 
            this.tb_saldoini.Location = new System.Drawing.Point(90, 86);
            this.tb_saldoini.Name = "tb_saldoini";
            this.tb_saldoini.Size = new System.Drawing.Size(80, 20);
            this.tb_saldoini.TabIndex = 10;
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(90, 175);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(75, 23);
            this.btn_criar.TabIndex = 11;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // NovaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.tb_saldoini);
            this.Controls.Add(this.lb_display_saldo);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.tb_agencia);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.radioBtn_investimento);
            this.Controls.Add(this.radioBtn_poupanca);
            this.Controls.Add(this.lb_numConta);
            this.Controls.Add(this.lb_display_num);
            this.Controls.Add(this.lb_displayage);
            this.Controls.Add(this.lb_displayname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NovaConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_displayname;
        private System.Windows.Forms.Label lb_displayage;
        private System.Windows.Forms.Label lb_display_num;
        private System.Windows.Forms.Label lb_numConta;
        private System.Windows.Forms.RadioButton radioBtn_poupanca;
        private System.Windows.Forms.RadioButton radioBtn_investimento;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_agencia;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_display_saldo;
        private System.Windows.Forms.TextBox tb_saldoini;
        private System.Windows.Forms.Button btn_criar;
    }
}