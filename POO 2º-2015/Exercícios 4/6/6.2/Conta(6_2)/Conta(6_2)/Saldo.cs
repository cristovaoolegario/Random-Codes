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
    public partial class Saldo : Form
    {
        public Saldo()
        {
            InitializeComponent();
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            int a;
            
            try
            {
                a = int.Parse(tb_numconta.Text);
                if (Contole.lista[a - 1].ativa)
                {
                    lb_display_saldo.Text =Convert.ToString(Contole.lista[a - 1].Saldo);
                }
                else
                {
                    MessageBox.Show("Conta não existente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
    
            }
            catch
            {
                MessageBox.Show("Conta não existente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
