using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Text = string.Empty;
            txtSecondNumber.Text = string.Empty;
            txtResult.Text = string.Empty;
            txtFirstNumber.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtFirstNumber.Text, out double num1))
            {
                MessageBox.Show("Please enter a valid first number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtSecondNumber.Text, out double num2))
            {
                MessageBox.Show("Please enter a valid second number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = num1 + num2;
            txtResult.Text = result.ToString();
        }
    }
}
