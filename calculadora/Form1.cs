using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN2.Text);
                double resultado = n1 + n2;
                lblResultado.Text = resultado.ToString("F2");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            {
                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN2.Text);
                double resultado = n1 - n2;
                lblResultado.Text = resultado.ToString("F2");
            }
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            {
                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN2.Text);
                double resultado = n1 * n2;
                lblResultado.Text = resultado.ToString("F2");
            }
        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            {
                double n1 = Convert.ToDouble(txtN1.Text);
                double n2 = Convert.ToDouble(txtN2.Text);
                double resultado = n1 / n2;
                lblResultado.Text = resultado.ToString("F2");
            }
        }
    }
    }
    }
    }
}
