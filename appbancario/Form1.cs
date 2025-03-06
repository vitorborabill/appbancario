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

        void veriflim()
        {
            double limite = (double)limitenum.Value;
            double saldo = Double.Parse(lblsaldo.Text);
            double nemlim = limite * -1;
            if (saldo < nemlim)
            {
                MessageBox.Show("Não permitido");
            }
        }


        private void btdeposit_Click(object sender, EventArgs e)
        {
            double num1, num2 = 0, result = 0;
            num1 = (double)valornum.Value;
            if (lblsaldo.Text != "")
                num2 = Double.Parse(lblsaldo.Text);
            result = num2 + num1;
            lblsaldo.Text = result.ToString();
        }

        private void btsacar_Click(object sender, EventArgs e)
        {
            double n1, n2 = 0, res = 0, limite = 0;
            limite = (double)limitenum.Value * -1;
            n1 = (double)valornum.Value;
            if(lblsaldo.Text != "")
                n2 = Double.Parse(lblsaldo.Text);
            res = n2 - n1;
            if(res < limite) 
                MessageBox.Show("Não permitido");
            else
                lblsaldo.Text = res.ToString();
        }

        private void lblsaldo_TextChanged(object sender, EventArgs e)
        {
            veriflim();
        }
    }
}
