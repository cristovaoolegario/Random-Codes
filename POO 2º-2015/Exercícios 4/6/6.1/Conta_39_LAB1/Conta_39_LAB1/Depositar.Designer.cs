namespace Conta_39_LAB1
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
            this.bt_depositar = new System.Windows.Forms.Button();
            this.tBox_valor = new System.Windows.Forms.TextBox();
            this.lb_display2 = new System.Windows.Forms.Label();
            this.lb_display1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_depositar
            // 
            this.bt_depositar.Location = new System.Drawing.Point(74, 66);
            this.bt_depositar.Name = "bt_depositar";
            this.bt_depositar.Size = new System.Drawing.Size(80, 41);
            this.bt_depositar.TabIndex = 0;
            this.bt_depositar.Text = "Depositar";
            this.bt_depositar.UseVisualStyleBackColor = true;
            this.bt_depositar.Click += new System.EventHandler(this.bt_depositar_Click);
            // 
            // tBox_valor
            // 
            this.tBox_valor.Location = new System.Drawing.Point(58, 40);
            this.tBox_valor.Name = "tBox_valor";
            this.tBox_valor.Size = new System.Drawing.Size(124, 20);
            this.tBox_valor.TabIndex = 1;
            // 
            // lb_display2
            // 
            this.lb_display2.AutoSize = true;
            this.lb_display2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_display2.Location = new System.Drawing.Point(12, 41);
            this.lb_display2.Name = "lb_display2";
            this.lb_display2.Size = new System.Drawing.Size(40, 16);
            this.lb_display2.TabIndex = 2;
            this.lb_display2.Text = "Valor";
            // 
            // lb_display1
            // 
            this.lb_display1.AutoSize = true;
            this.lb_display1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_display1.Location = new System.Drawing.Point(71, 21);
            this.lb_display1.Name = "lb_display1";
            this.lb_display1.Size = new System.Drawing.Size(98, 16);
            this.lb_display1.TabIndex = 3;
            this.lb_display1.Text = "Deposite aqui !";
            // 
            // Depositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 117);
            this.Controls.Add(this.lb_display1);
            this.Controls.Add(this.lb_display2);
            this.Controls.Add(this.tBox_valor);
            this.Controls.Add(this.bt_depositar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Depositar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Depositar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_depositar;
        private System.Windows.Forms.TextBox tBox_valor;
        private System.Windows.Forms.Label lb_display2;
        private System.Windows.Forms.Label lb_display1;
    }
}