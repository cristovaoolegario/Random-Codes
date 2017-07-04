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
    public partial class Sacar : Form
    {
        public Sacar()
        {
            InitializeComponent();
        }

        private void btn_saque_Click(object sender, EventArgs e)
        {
            int a;
            double b;
            try
            {
                a = int.Parse(tb_numconta.Text);
                b = double.Parse(tb_saque.Text);
                if (b < 0)
                {
                    MessageBox.Show("Não sacamos valores negativos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Contole.lista[a - 1].sacar(b);
                    
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Valores inválidos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
