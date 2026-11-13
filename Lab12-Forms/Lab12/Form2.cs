using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class StudentEnrollment : Form
    {
        public StudentEnrollment()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Full name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                MessageBox.Show("Student ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDegree.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Degree Program.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCourses.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = rdoMale.Checked ? "Male" : "Female";
            string courses = cmbCourses.SelectedItem.ToString();

            string summary =
                 "Enrollment Summary\n" +
                 "──────────────────────\n" +
                 "Name: " + txtName.Text + "\n" +
                 "Student ID: " + txtStudentID.Text + "\n" +
                 "Gender: " + gender + "\n" +
                 "Degree: " + cmbDegree.SelectedItem.ToString() + "\n" +
                 "Semester: " + nudSemester.Value + "\n" +
                 "Course: " + courses + "\n" +
                 "Date: " + dtpEnrollment.Value.ToShortDateString();

            MessageBox.Show(summary, "Enrollment Confirmed", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // TextBoxes
            txtName.Clear();
            txtStudentID.Clear();

            // RadioButtons (Gender)
            rdoMale.Checked = false;
            rdoFemale.Checked = false;

            // ComboBoxes
            cmbDegree.SelectedIndex = -1;
            cmbCourses.SelectedIndex = -1;

            // NumericUpDown (Semester)
            nudSemester.Value = nudSemester.Minimum;

            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
