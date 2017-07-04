namespace Conta_39_LAB1
{
    partial class Conta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conta));
            this.bt_depositar = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_imprimir = new System.Windows.Forms.Button();
            this.bt_sacar = new System.Windows.Forms.Button();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_conta = new System.Windows.Forms.Label();
            this.lb_agencia = new System.Windows.Forms.Label();
            this.lb_dislpay1 = new System.Windows.Forms.Label();
            this.lb_display2 = new System.Windows.Forms.Label();
            this.lb_display3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samaraLuizaDaSilvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samaraLuizaDaSilva536592ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andrewDeOliveiraDuchini537983ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cristóvãoOlegárioDeCastro536584ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_depositar
            // 
            this.bt_depositar.Location = new System.Drawing.Point(26, 106);
            this.bt_depositar.Name = "bt_depositar";
            this.bt_depositar.Size = new System.Drawing.Size(80, 44);
            this.bt_depositar.TabIndex = 0;
            this.bt_depositar.Text = "Depositar";
            this.bt_depositar.UseVisualStyleBackColor = true;
            this.bt_depositar.Click += new System.EventHandler(this.bt_depositar_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(112, 156);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(80, 44);
            this.bt_sair.TabIndex = 1;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_imprimir
            // 
            this.bt_imprimir.Location = new System.Drawing.Point(26, 156);
            this.bt_imprimir.Name = "bt_imprimir";
            this.bt_imprimir.Size = new System.Drawing.Size(80, 44);
            this.bt_imprimir.TabIndex = 2;
            this.bt_imprimir.Text = "Imprimir Saldo";
            this.bt_imprimir.UseVisualStyleBackColor = true;
            this.bt_imprimir.Click += new System.EventHandler(this.bt_imprimir_Click);
            // 
            // bt_sacar
            // 
            this.bt_sacar.Location = new System.Drawing.Point(112, 106);
            this.bt_sacar.Name = "bt_sacar";
            this.bt_sacar.Size = new System.Drawing.Size(80, 44);
            this.bt_sacar.TabIndex = 3;
            this.bt_sacar.Text = "Sacar";
            this.bt_sacar.UseVisualStyleBackColor = true;
            this.bt_sacar.Click += new System.EventHandler(this.bt_sacar_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(71, 24);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(35, 13);
            this.lb_nome.TabIndex = 4;
            this.lb_nome.Text = "label1";
            // 
            // lb_conta
            // 
            this.lb_conta.AutoSize = true;
            this.lb_conta.Location = new System.Drawing.Point(71, 49);
            this.lb_conta.Name = "lb_conta";
            this.lb_conta.Size = new System.Drawing.Size(35, 13);
            this.lb_conta.TabIndex = 5;
            this.lb_conta.Text = "label2";
            // 
            // lb_agencia
            // 
            this.lb_agencia.AutoSize = true;
            this.lb_agencia.Location = new System.Drawing.Point(71, 75);
            this.lb_agencia.Name = "lb_agencia";
            this.lb_agencia.Size = new System.Drawing.Size(35, 13);
            this.lb_agencia.TabIndex = 6;
            this.lb_agencia.Text = "label3";
            // 
            // lb_dislpay1
            // 
            this.lb_dislpay1.AutoSize = true;
            this.lb_dislpay1.Location = new System.Drawing.Point(23, 24);
            this.lb_dislpay1.Name = "lb_dislpay1";
            this.lb_dislpay1.Size = new System.Drawing.Size(38, 13);
            this.lb_dislpay1.TabIndex = 7;
            this.lb_dislpay1.Text = "Nome:";
            // 
            // lb_display2
            // 
            this.lb_display2.AutoSize = true;
            this.lb_display2.Location = new System.Drawing.Point(23, 49);
            this.lb_display2.Name = "lb_display2";
            this.lb_display2.Size = new System.Drawing.Size(38, 13);
            this.lb_display2.TabIndex = 8;
            this.lb_display2.Text = "Conta:";
            // 
            // lb_display3
            // 
            this.lb_display3.AutoSize = true;
            this.lb_display3.Location = new System.Drawing.Point(23, 75);
            this.lb_display3.Name = "lb_display3";
            this.lb_display3.Size = new System.Drawing.Size(49, 13);
            this.lb_display3.TabIndex = 9;
            this.lb_display3.Text = "Agência:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programadoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(226, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programadoresToolStripMenuItem
            // 
            this.programadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.samaraLuizaDaSilvaToolStripMenuItem,
            this.samaraLuizaDaSilva536592ToolStripMenuItem,
            this.andrewDeOliveiraDuchini537983ToolStripMenuItem,
            this.cristóvãoOlegárioDeCastro536584ToolStripMenuItem});
            this.programadoresToolStripMenuItem.Name = "programadoresToolStripMenuItem";
            this.programadoresToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.programadoresToolStripMenuItem.Text = "Programadores";
            // 
            // samaraLuizaDaSilvaToolStripMenuItem
            // 
            this.samaraLuizaDaSilvaToolStripMenuItem.Name = "samaraLuizaDaSilvaToolStripMenuItem";
            this.samaraLuizaDaSilvaToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.samaraLuizaDaSilvaToolStripMenuItem.Text = "Pedro Lucas Duarte Faria(536589)";
            // 
            // samaraLuizaDaSilva536592ToolStripMenuItem
            // 
            this.samaraLuizaDaSilva536592ToolStripMenuItem.Name = "samaraLuizaDaSilva536592ToolStripMenuItem";
            this.samaraLuizaDaSilva536592ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.samaraLuizaDaSilva536592ToolStripMenuItem.Text = "Samara Luiza da Silva(536592)";
            // 
            // andrewDeOliveiraDuchini537983ToolStripMenuItem
            // 
            this.andrewDeOliveiraDuchini537983ToolStripMenuItem.Name = "andrewDeOliveiraDuchini537983ToolStripMenuItem";
            this.andrewDeOliveiraDuchini537983ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.andrewDeOliveiraDuchini537983ToolStripMenuItem.Text = "Andrew de Oliveira Duchini (537983)";
            // 
            // cristóvãoOlegárioDeCastro536584ToolStripMenuItem
            // 
            this.cristóvãoOlegárioDeCastro536584ToolStripMenuItem.Name = "cristóvãoOlegárioDeCastro536584ToolStripMenuItem";
            this.cristóvãoOlegárioDeCastro536584ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.cristóvãoOlegárioDeCastro536584ToolStripMenuItem.Text = "Cristóvão Olegário de Castro (536584)";
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 212);
            this.Controls.Add(this.lb_display3);
            this.Controls.Add(this.lb_display2);
            this.Controls.Add(this.lb_dislpay1);
            this.Controls.Add(this.lb_agencia);
            this.Controls.Add(this.lb_conta);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.bt_sacar);
            this.Controls.Add(this.bt_imprimir);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_depositar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Conta";
            this.Text = "Conta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_depositar;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_imprimir;
        private System.Windows.Forms.Button bt_sacar;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_conta;
        private System.Windows.Forms.Label lb_agencia;
        private System.Windows.Forms.Label lb_dislpay1;
        private System.Windows.Forms.Label lb_display2;
        private System.Windows.Forms.Label lb_display3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem samaraLuizaDaSilvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem samaraLuizaDaSilva536592ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem andrewDeOliveiraDuchini537983ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cristóvãoOlegárioDeCastro536584ToolStripMenuItem;
    }
}

