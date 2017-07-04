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
    public partial class ExcluirConta : Form
    {
        public ExcluirConta()
        {
            InitializeComponent();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = int.Parse(tb_numconta.Text);
                Contole.lista[a - 1].ativa = false;
                MessageBox.Show("Conta excluida!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Valores inválidos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
