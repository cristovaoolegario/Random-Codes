using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta_39_LAB1
{
    public partial class Depositar : Form
    {
        public Depositar()
        {
            InitializeComponent();
        }

        private void bt_depositar_Click(object sender, EventArgs e)
        {
            try
            {
                double a;
                a = double.Parse(tBox_valor.Text);
                if (a < 0)
                {
                    MessageBox.Show("Não depositamos valores negativos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Conta.Saldo = Conta.Saldo+double.Parse(tBox_valor.Text);
                }
                
                this.Close(); 
            }
            catch
            {
                MessageBox.Show("Valor inválido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
