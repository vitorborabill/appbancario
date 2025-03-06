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

        private void btdeposit_Click(object sender, EventArgs e)
        {
            int verif = 0;
            verif++;
            double num1 = 0, num2 = 0, result = 0;
            if(lblsaldo.Text != "")
            {
                num1 = (double)valornum.Value;
                num2 = Double.Parse(lblsaldo.Text);
                result = num1 + num2;
                lblsaldo.Text = result.ToString();
            }
            else
            {
                num1 = (double)valornum.Value;
                result = num1 + num2;
                lblsaldo.Text = result.ToString();
            }
        }
    }
}
