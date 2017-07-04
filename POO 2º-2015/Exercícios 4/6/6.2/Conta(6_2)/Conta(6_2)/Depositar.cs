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
    public partial class Depositar : Form
    {
        public Depositar()
        {
            InitializeComponent();
        }

        private void btn_deposito_Click(object sender, EventArgs e)
        {
            int a;
            double b;

            try
            {
                a = int.Parse(tb_numconta.Text);
                b = double.Parse(tb_deposito.Text);
                if (b<0)
                {
                    MessageBox.Show("Valores inválidos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Contole.lista[a - 1].depositar(b);
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Valores inválidos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Conta não existente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
