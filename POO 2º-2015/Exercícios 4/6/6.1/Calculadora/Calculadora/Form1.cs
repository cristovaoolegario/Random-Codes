using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double a, b;
        string bla;
        char op = 'f';
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = double.Parse(lb_displaynumbers.Text);
            lb_displayresult.Text = (lb_displaynumbers.Text + "-");
            lb_displaynumbers.Text = "";
            op = '-';
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            lb_displaynumbers.Text = (lb_displaynumbers.Text + "1");
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            lb_displaynumbers.Text = (lb_displaynumbers.Text + "2");
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            lb_displaynumbers.Text = (lb_displaynumbers.Text + "3");
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            lb_displaynumbers.Text = (lb_displaynumbers.Text + "4");
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            lb_displaynumbers.Text = (lb_displaynumbers.Text + "5");
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            lb_displaynumbers.Text = (lb_displaynumbers.Text + "6");
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            lb_displaynumbers.Text = (lb_displaynumbers.Text + "7");
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            lb_displaynumbers.Text = (lb_displaynumbers.Text + "8");
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            lb_displaynumbers.Text = (lb_displaynumbers.Text + "9");
        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            lb_displaynumbers.Text = (lb_displaynumbers.Text + ",");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            lb_displaynumbers.Text = (lb_displaynumbers.Text + "0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            a = double.Parse(lb_displaynumbers.Text);
            lb_displayresult.Text = (lb_displaynumbers.Text + "+");
            lb_displaynumbers.Text = "";
            op = '+';
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            a = double.Parse(lb_displaynumbers.Text);
            lb_displayresult.Text = (lb_displaynumbers.Text + "*");
            lb_displaynumbers.Text = "";
            op = '*';
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            a = double.Parse(lb_displaynumbers.Text);
            lb_displayresult.Text = (lb_displaynumbers.Text + "/");
            lb_displaynumbers.Text = "";
            op = '/';
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            b = double.Parse(lb_displaynumbers.Text);
            lb_displayresult.Text = (lb_displayresult.Text + b);
            bla = lb_displayresult.Text;
            lb_displaynumbers.Text = "";
            lb_displayresult.Text = (bla + " = " + Calcula.Acheoperacao(a, b, op));
        }


    }
}
