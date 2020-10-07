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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtVisor.Focus();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {

            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "1";
            }
            else
            {
                txtVisor.Text += "1";
            }

        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "2";
            }
            else
            {
                txtVisor.Text += "2";
            }
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "3";
            }
            else
            {
                txtVisor.Text += "3";
            }
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "4";
            }
            else
            {
                txtVisor.Text += "4";
            }
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "5";
            }
            else
            {
                txtVisor.Text += "5";
            }
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "6";
            }
            else
            {
                txtVisor.Text += "6";
            }
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "7";
            }
            else
            {
                txtVisor.Text += "7";
            }
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "8";
            }
            else
            {
                txtVisor.Text += "8";
            }
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
                txtVisor.Text = "9";
            }
            else
            {
                txtVisor.Text += "9";
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text == "0")
            {
            }
            else
            {
                txtVisor.Text += "0";
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Text = "0";
            txtVisor.Focus();
        }

        private void txtVisor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Back && (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9 || e.Shift == true))
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9 || e.Shift == true)
                {
                    e.SuppressKeyPress = true;
                    return;
                }
            }


            if (txtVisor.Text == "0")
            {
                txtVisor.Text = string.Empty;
            }

            if (e.KeyCode == Keys.Back && txtVisor.Text == string.Empty)
            {
                txtVisor.Text = "0";
            }

        }


        private void txtVisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && (e.KeyChar < (char)Keys.D0 || e.KeyChar > (char)Keys.D9))
            {
                if (e.KeyChar < (char)Keys.NumPad0 || e.KeyChar > (char)Keys.NumPad9)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}