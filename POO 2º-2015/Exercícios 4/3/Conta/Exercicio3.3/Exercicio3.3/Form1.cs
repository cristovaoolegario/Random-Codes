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
    public partial class Form1 : Form
    {
        public static double saldo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            Deposito a = new Deposito();
            a.Show();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo da Conta: " + saldo);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            FormSaque a = new FormSaque();
            a.Show();
        }
    }
}
