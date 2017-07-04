using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta_6_2_
{
    class Conta
    {
        protected DateTime abertura; // data de abertura da conta
        protected String nome; // nome do titular da conta
        protected int agencia; // número da agência da conta
        protected double saldo; // saldo atual da conta
        protected int numConta; // número da conta
        protected int tipoConta; // indica o tipo da conta: corrente, poupança ou investimento 
        public static int cont = 0; //contador de contas existentes
        public bool ativa = true;

        public void depositar(double credito)
        {
            if ((ativa))
            {
                saldo += credito;
                MessageBox.Show("Valor depositado", "Depósito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Conta não existente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
           
        }
        public void sacar(double valor)
        {
            if ((ativa))
            {
                saldo -= valor;
                MessageBox.Show("Valor retirado!!", "Sacar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Conta não existente", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void imprimeSaldo()
        {
            
        }

        public string getNome()
        {
            return this.nome;
        }

        public int getAgencia()
        {
            return this.agencia;
        }

        public double Saldo
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        public int getNum()
        {
            return this.numConta;
        }

        public int getTipo_Conta()
        {
            return this.tipoConta;
        }

        public int mesesInvestidos(DateTime atual)
        {
            TimeSpan dif = atual.Subtract(abertura);
            int meses = dif.Days / 30;
            return meses;
        }

        public DateTime Abertura
        {
            set { abertura = value; }
            get { return abertura; }
        }
    }
}
