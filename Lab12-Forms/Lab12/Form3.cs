using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void txtResult_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtFirstNumber.Text, out double num1))
            {
                MessageBox.Show("Not a Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtSecondNumber.Text, out double num2))
            {
                MessageBox.Show("Not a Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (opSelector.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Program.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string op  = opSelector.SelectedItem.ToString();
            double result = 0;

            if (op == "+")
            {
                result = num1 + num2;
            } else if (op == "-")
            {
                result = num1 - num2;
            } else if (op == "*")
            {
                result = num1 * num2;
            } else if (op == "/")
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero.", "Division By Zero Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                result = num1 / num2;
            }

            txtResult.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            opSelector.SelectedIndex = -1;
            txtResult.Clear();
            txtFirstNumber.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
