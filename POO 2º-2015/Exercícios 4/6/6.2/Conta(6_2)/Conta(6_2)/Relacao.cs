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
    public partial class Relacao : Form
    {
        public Relacao()
        {
            InitializeComponent();
            listBox1.Text = "";
            for(int i = 0; i<Conta.cont; i++)
            {
                if (Contole.lista[i].ativa)
                {
                    listBox1.Items.Add("NOME: " + Contole.lista[i].getNome() + " AGÊNCIA: " + Contole.lista[i].getAgencia());
                }
            }
        }
    }
}
