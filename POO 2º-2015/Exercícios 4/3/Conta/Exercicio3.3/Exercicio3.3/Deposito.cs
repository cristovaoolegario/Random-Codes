using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3._3
{
    public partial class Deposito : Form
    {
        
        public Deposito()
        {
            InitializeComponent();
        }
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if (txtDeposito.Text == "")
            {
                MessageBox.Show("Digite um valor antes de depositar!", "OPA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double valor = double.Parse(txtDeposito.Text);
                Form1.saldo += valor;
                MessageBox.Show("Deposito realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }
    }
}
