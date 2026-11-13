using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab12.Assignment
{
    public partial class GradeCalculator : Form
    {
        public GradeCalculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GradeCalculator_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcGrade_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentName.Text))
            {
                MessageBox.Show("Student name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtStudentRollNumber.Text))
            {
                MessageBox.Show("Student Roll Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSemesterSelection.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a semester.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int mathMarks = Convert.ToInt32(nupMaths.Value);
            int physicsMarks = Convert.ToInt32(nupPhysics.Value);
            int chemistryMarks = Convert.ToInt32(nupChemistry.Value);
            int csMarks = Convert.ToInt32(nupComputerScience.Value);

            int avgMarks = Convert.ToInt32((mathMarks + physicsMarks + chemistryMarks + csMarks) / 4.0);
            char grade;

            if (avgMarks <= 100 && avgMarks >= 85)
            {
                grade = 'A';
            } else if (avgMarks <= 84 && avgMarks >= 70)
            {
                grade = 'B';
            } else if (avgMarks <= 69 && avgMarks >= 55)
            {
                grade = 'C';
            } else if (avgMarks <= 54 && avgMarks >= 40)
            {
                grade = 'D';
            } else
            {
                grade = 'F';
            }

            string summary =
            "\n Grade Calculator \n" +
            "──────────────────────\n" +
            "Student Name: " + txtStudentName.Text + "\n" +
            "Student ID: " + txtStudentRollNumber.Text + "\n" +
            "Semester: " + cmbSemesterSelection.SelectedItem.ToString() + "\n" +
            "\n Grade \n" + grade + "\n";

            MessageBox.Show(summary, "Result", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtStudentRollNumber.Clear();
            cmbSemesterSelection.SelectedIndex = -1;
            nupMaths.Value = nupMaths.Minimum;
            nupPhysics.Value = nupPhysics.Minimum;
            nupChemistry.Value = nupChemistry.Minimum;
            nupComputerScience.Value = nupComputerScience.Minimum;
        }
    }
    }

