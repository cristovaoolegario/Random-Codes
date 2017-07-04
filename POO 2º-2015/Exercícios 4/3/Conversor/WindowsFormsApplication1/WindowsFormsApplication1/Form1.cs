using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCelsius.Enabled = false;
            txtFahr.Enabled = false;
            btnConverter.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtCelsius.Enabled = true;
            txtFahr.Enabled = false;
            btnConverter.Enabled = true;
            txtFahr.Clear();
        }

        private void rbFahr_CheckedChanged(object sender, EventArgs e)
        {
            txtFahr.Enabled = true;
            txtCelsius.Enabled = false;
            btnConverter.Enabled = true;
            txtCelsius.Clear();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double temp;
            if (rbCelsius.Checked == true)
            {
                if (txtCelsius.Text != "")
                {
                    temp = double.Parse(txtCelsius.Text);
                    string msg = "Conversão de Celsius para Fahrenheit!\n" + temp + "°C = " + Math.Round(CelsiusToFahrenheit(temp), 2) + "°F";
                    MessageBox.Show(null, msg, "Resultado da Conversão", MessageBoxButtons.OK);
                    limpar();
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo!", "Aviso!");
                }
                
            }
            else if(rbFahr.Checked == true)
            {
                if (txtFahr.Text != "")
                {
                    temp = double.Parse(txtFahr.Text);
                    string msg = "Conversão de Fahrenheit para Celsius!\n" + temp + "°F = " + Math.Round(FahrenheitToCelcius(temp),2) + "°C";
                    MessageBox.Show(null, msg, "Resultado da Conversão", MessageBoxButtons.OK);
                    limpar();   
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo!","Aviso!");
                }
            }
        }

        private void limpar()
        {
            txtCelsius.Clear();
            rbCelsius.Checked = false;
            txtCelsius.Enabled = false;
            txtFahr.Clear();
            rbFahr.Checked = false;
            txtFahr.Enabled = false;
            btnConverter.Enabled = false;
        }

        private double CelsiusToFahrenheit(double temperatura)
        {
            double conversao;
            conversao = (temperatura * 1.8) + 32;

            return conversao;
        }

        private double FahrenheitToCelcius(double temperatura)
        {
            double conversao;
            conversao = (temperatura - 32) / 1.8;

            return conversao;
        }        
    }
}
