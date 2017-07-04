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
    public partial class Conta : Form
    {
        public int agencia;
        public int numero; // número da Conta Bancária
        public string nome; // nome do titular da conta public
        public static double Saldo;
        public Conta()
        {
            InitializeComponent();
            agencia = 1010;
            numero = 015256;
            nome = "Samara Luiza da Silva";
            Saldo = 0;
            lb_nome.Text = nome;
            lb_conta.Text = ""+ numero;
            lb_agencia.Text = "" + agencia;
        }

        private void bt_depositar_Click(object sender, EventArgs e)
        {
            Depositar a = new Depositar();
            a.Show();
        }

        private void bt_sacar_Click(object sender, EventArgs e)
        {
            Sacar b = new Sacar();
            b.Show();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_imprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(("Saldo: " + Saldo), "Saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
