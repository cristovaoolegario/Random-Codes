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
    public partial class NovaConta : Form
    {

        DateTime r = new DateTime();
        public NovaConta()
        {
            InitializeComponent();
            lb_data.Text = (r.Day + "/" + r.Month + "/" + r.Year);
            lb_numConta.Text = Convert.ToString(Conta.cont+1);
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            string nome = "";
            int ag = 0;
            double saldoInicial = 0;
            try
            {
                
                nome = tb_nome.Text;
                ag = int.Parse(tb_agencia.Text);
                saldoInicial = double.Parse(tb_saldoini.Text);
                if (radioBtn_poupanca.Checked)
                {
                    Poupanca a = new Poupanca(nome, ag, saldoInicial, r);
                    Contole.lista.Add(a);
                    MessageBox.Show("Conta criada com sucesso!!", "Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (radioBtn_poupanca.Checked)
                {
                    Investimento a = new Investimento(nome, ag, saldoInicial, r);
                    Contole.lista.Add(a);
                    MessageBox.Show("Conta criada com sucesso!!", "Conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Marque uma opção", "COMPLETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Valores inválidos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        
    }
}
