namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahr = new System.Windows.Forms.TextBox();
            this.rbCelsius = new System.Windows.Forms.RadioButton();
            this.rbFahr = new System.Windows.Forms.RadioButton();
            this.lbCelsius = new System.Windows.Forms.Label();
            this.lbFahr = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedroLucasDuarteFaria536589ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.samaraLuizaDaSilva536592ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andrewDeOliveiraDuchini537983ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cristóvãoOlegárioDeCastro536584ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor Celsius / Fahrenheit";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(98, 58);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(174, 20);
            this.txtCelsius.TabIndex = 1;
            // 
            // txtFahr
            // 
            this.txtFahr.Location = new System.Drawing.Point(98, 97);
            this.txtFahr.Name = "txtFahr";
            this.txtFahr.Size = new System.Drawing.Size(174, 20);
            this.txtFahr.TabIndex = 2;
            // 
            // rbCelsius
            // 
            this.rbCelsius.AutoSize = true;
            this.rbCelsius.Location = new System.Drawing.Point(78, 61);
            this.rbCelsius.Name = "rbCelsius";
            this.rbCelsius.Size = new System.Drawing.Size(14, 13);
            this.rbCelsius.TabIndex = 3;
            this.rbCelsius.UseVisualStyleBackColor = true;
            this.rbCelsius.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbFahr
            // 
            this.rbFahr.AutoSize = true;
            this.rbFahr.Location = new System.Drawing.Point(78, 100);
            this.rbFahr.Name = "rbFahr";
            this.rbFahr.Size = new System.Drawing.Size(14, 13);
            this.rbFahr.TabIndex = 4;
            this.rbFahr.UseVisualStyleBackColor = true;
            this.rbFahr.CheckedChanged += new System.EventHandler(this.rbFahr_CheckedChanged);
            // 
            // lbCelsius
            // 
            this.lbCelsius.AutoSize = true;
            this.lbCelsius.Location = new System.Drawing.Point(12, 61);
            this.lbCelsius.Name = "lbCelsius";
            this.lbCelsius.Size = new System.Drawing.Size(40, 13);
            this.lbCelsius.TabIndex = 5;
            this.lbCelsius.Text = "Celsius";
            // 
            // lbFahr
            // 
            this.lbFahr.AutoSize = true;
            this.lbFahr.Location = new System.Drawing.Point(12, 100);
            this.lbFahr.Name = "lbFahr";
            this.lbFahr.Size = new System.Drawing.Size(57, 13);
            this.lbFahr.TabIndex = 6;
            this.lbFahr.Text = "Fahrenheit";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(98, 175);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 7;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programadoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programadoresToolStripMenuItem
            // 
            this.programadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedroLucasDuarteFaria536589ToolStripMenuItem,
            this.samaraLuizaDaSilva536592ToolStripMenuItem,
            this.andrewDeOliveiraDuchini537983ToolStripMenuItem,
            this.cristóvãoOlegárioDeCastro536584ToolStripMenuItem});
            this.programadoresToolStripMenuItem.Name = "programadoresToolStripMenuItem";
            this.programadoresToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.programadoresToolStripMenuItem.Text = "Programadores";
            // 
            // pedroLucasDuarteFaria536589ToolStripMenuItem
            // 
            this.pedroLucasDuarteFaria536589ToolStripMenuItem.Name = "pedroLucasDuarteFaria536589ToolStripMenuItem";
            this.pedroLucasDuarteFaria536589ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.pedroLucasDuarteFaria536589ToolStripMenuItem.Text = "Pedro Lucas Duarte Faria(536589) ";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lbFahr);
            this.Controls.Add(this.lbCelsius);
            this.Controls.Add(this.rbFahr);
            this.Controls.Add(this.rbCelsius);
            this.Controls.Add(this.txtFahr);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahr;
        private System.Windows.Forms.RadioButton rbCelsius;
        private System.Windows.Forms.RadioButton rbFahr;
        private System.Windows.Forms.Label lbCelsius;
        private System.Windows.Forms.Label lbFahr;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedroLucasDuarteFaria536589ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem samaraLuizaDaSilva536592ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem andrewDeOliveiraDuchini537983ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cristóvãoOlegárioDeCastro536584ToolStripMenuItem;
    }
}

