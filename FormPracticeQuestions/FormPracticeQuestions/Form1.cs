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
    public partial class Shopping : Form
    {
        public Shopping()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPrice.Text, out double price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; MessageBox.Show("Price is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtQuantity.Text, out double quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double result = price * quantity;
            txtTotalPrice.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrice.Clear();
            txtQuantity.Clear();
            txtTotalPrice.Clear();
            txtPrice.Focus();
        }
    }
}
