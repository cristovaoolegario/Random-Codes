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

    public partial class Sacar : Form
    {
        double a;
        public Sacar()
        {
            InitializeComponent();
            a = 0;
        }

        private void bt_sacar_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(tBox_valor.Text);
                if(a<0)
                {
                    MessageBox.Show("Não retiramos valores negativos", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (a <= Conta.Saldo)
                    {
                        Conta.Saldo = Conta.Saldo - a;
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Valor inválido", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
