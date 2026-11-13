using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPracticeQuestions
{
    public partial class MathCalculator : Form
    {
        public MathCalculator()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtFirstNumber.Text, out double num1))
            {
                MessageBox.Show("Not a number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtSecondNumber.Text, out double num2))
            {
                MessageBox.Show("Not a number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbOperator.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select an operator.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = 0;
            if (cmbOperator.Text == "+")
            {
                result = num1 + num2;
            } else if (cmbOperator.Text == "-")
            {
                result = num1 - num2;
            } else if (cmbOperator.Text == "*")
            {
                result = num1 * num2;
            } else if (cmbOperator.Text == "/")
            {
                if (num2 == 0)
                {
                    MessageBox.Show("Cannot divide by zero", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtResult.Clear();
            cmbOperator.SelectedIndex = 0;
            txtFirstNumber.Focus();
        }
    }
}
