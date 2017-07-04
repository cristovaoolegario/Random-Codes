using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta_6_2_
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Contole.Ler();
        }

        private void btn_novaconta_Click(object sender, EventArgs e)
        {
            NovaConta a = new NovaConta();
            a.Show();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            ExcluirConta a = new ExcluirConta();
            a.Show();
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            Depositar a = new Depositar();
            a.Show();
        }

        private void btn_sacar_Click(object sender, EventArgs e)
        {
            Sacar a = new Sacar();
            a.Show();
        }

        private void btn_saldo_Click(object sender, EventArgs e)
        {
            Saldo a = new Saldo();
            a.Show();
        }

        private void btn_contas_Click(object sender, EventArgs e)
        {
            Relacao a = new Relacao();
            a.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Contole.Gravar();
            this.Close();
        }

        private void pedroLucasDuarteFaria536589ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
