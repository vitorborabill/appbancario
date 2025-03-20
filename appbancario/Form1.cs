using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace appbancario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double saldo = 0;
        double taxa = 0.01;

        void veriflim()
        {
            double limite = (double)limitenum.Value;
            double nemlim = limite * -1;
            if (saldo < nemlim)
            {
                MessageBox.Show("Não permitido: Limite excedido.");
            }
        }

        void AtualizarSaldo(double novoSaldo)
        {
            saldo = novoSaldo;
            lblsaldo.Text = saldo.ToString("c"); 
            veriflim(); 
        }


        private void btdeposit_Click(object sender, EventArgs e)
        {
            double valorDeposito = (double)valornum.Value;
            if (valorDeposito > 0)
            {
                AtualizarSaldo(saldo + valorDeposito);
            }
            else
            {
                MessageBox.Show("Valor de depósito inválido.");
            }
        }

        private void btsacar_Click(object sender, EventArgs e)
        {
            double valorSaque = (double)valornum.Value;
            if (valorSaque > 0 && valorSaque <= saldo + (double)limitenum.Value)
            {
                AtualizarSaldo(saldo - valorSaque);
            }
            else
            {
                MessageBox.Show("Valor de saque inválido ou limite excedido.");
            }
        }

        private void lblsaldo_TextChanged(object sender, EventArgs e)
        {
            veriflim();
        }

        private void tmrJuros_Tick(object sender, EventArgs e)
        {
            saldo += saldo * taxa;
            lblsaldo.Text = saldo.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaxa.Text =$"*Taxa: {taxa * 100}% a.c {(double)tmrJuros.Interval / 1000} seg";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja realmente sair?", "Resenha FC", MessageBoxButtons.YesNo);
            if(r == DialogResult.No)
                e.Cancel = true;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("VALEU BOBAO", "BANCO EUCLIDES");
        }
    }
}
