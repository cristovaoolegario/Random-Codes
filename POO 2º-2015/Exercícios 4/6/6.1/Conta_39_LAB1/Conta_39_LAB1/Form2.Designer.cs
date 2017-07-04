namespace Conta_39_LAB1
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
            this.tBox_valor = new System.Windows.Forms.TextBox();
            this.bt_sacar = new System.Windows.Forms.Button();
            this.lb_display2 = new System.Windows.Forms.Label();
            this.lb_dislpay1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBox_valor
            // 
            this.tBox_valor.Location = new System.Drawing.Point(58, 47);
            this.tBox_valor.Name = "tBox_valor";
            this.tBox_valor.Size = new System.Drawing.Size(122, 20);
            this.tBox_valor.TabIndex = 0;
            // 
            // bt_sacar
            // 
            this.bt_sacar.Location = new System.Drawing.Point(72, 73);
            this.bt_sacar.Name = "bt_sacar";
            this.bt_sacar.Size = new System.Drawing.Size(80, 41);
            this.bt_sacar.TabIndex = 1;
            this.bt_sacar.Text = "Sacar";
            this.bt_sacar.UseVisualStyleBackColor = true;
            this.bt_sacar.Click += new System.EventHandler(this.bt_sacar_Click);
            // 
            // lb_display2
            // 
            this.lb_display2.AutoSize = true;
            this.lb_display2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_display2.Location = new System.Drawing.Point(12, 48);
            this.lb_display2.Name = "lb_display2";
            this.lb_display2.Size = new System.Drawing.Size(40, 16);
            this.lb_display2.TabIndex = 2;
            this.lb_display2.Text = "Valor";
            // 
            // lb_dislpay1
            // 
            this.lb_dislpay1.AutoSize = true;
            this.lb_dislpay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dislpay1.Location = new System.Drawing.Point(69, 28);
            this.lb_dislpay1.Name = "lb_dislpay1";
            this.lb_dislpay1.Size = new System.Drawing.Size(78, 16);
            this.lb_dislpay1.TabIndex = 3;
            this.lb_dislpay1.Text = "Digite aqui!!";
            // 
            // Sacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 117);
            this.Controls.Add(this.lb_dislpay1);
            this.Controls.Add(this.lb_display2);
            this.Controls.Add(this.bt_sacar);
            this.Controls.Add(this.tBox_valor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sacar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_valor;
        private System.Windows.Forms.Button bt_sacar;
        private System.Windows.Forms.Label lb_display2;
        private System.Windows.Forms.Label lb_dislpay1;
    }
}