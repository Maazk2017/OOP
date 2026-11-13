namespace Lab12.Assignment
{
    partial class GradeCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentRollNumber = new System.Windows.Forms.TextBox();
            this.cmbSemesterSelection = new System.Windows.Forms.ComboBox();
            this.nupMaths = new System.Windows.Forms.NumericUpDown();
            this.nupPhysics = new System.Windows.Forms.NumericUpDown();
            this.nupChemistry = new System.Windows.Forms.NumericUpDown();
            this.nupComputerScience = new System.Windows.Forms.NumericUpDown();
            this.btnCalcGrade = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPhysics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupChemistry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupComputerScience)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Roll Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semster:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maths:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Physics:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(593, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chemistry:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(593, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Computer Science:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(216, 39);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 24);
            this.txtStudentName.TabIndex = 7;
            // 
            // txtStudentRollNumber
            // 
            this.txtStudentRollNumber.Location = new System.Drawing.Point(216, 97);
            this.txtStudentRollNumber.Name = "txtStudentRollNumber";
            this.txtStudentRollNumber.Size = new System.Drawing.Size(100, 24);
            this.txtStudentRollNumber.TabIndex = 8;
            // 
            // cmbSemesterSelection
            // 
            this.cmbSemesterSelection.FormattingEnabled = true;
            this.cmbSemesterSelection.Items.AddRange(new object[] {
            "Semster 1",
            "Semster 2",
            "Semster 3",
            "Semster 4",
            "Semster 5",
            "Semster 6",
            "Semster 7",
            "Semster 8"});
            this.cmbSemesterSelection.Location = new System.Drawing.Point(216, 150);
            this.cmbSemesterSelection.Name = "cmbSemesterSelection";
            this.cmbSemesterSelection.Size = new System.Drawing.Size(121, 26);
            this.cmbSemesterSelection.TabIndex = 9;
            // 
            // nupMaths
            // 
            this.nupMaths.Location = new System.Drawing.Point(754, 42);
            this.nupMaths.Name = "nupMaths";
            this.nupMaths.Size = new System.Drawing.Size(120, 24);
            this.nupMaths.TabIndex = 10;
            // 
            // nupPhysics
            // 
            this.nupPhysics.Location = new System.Drawing.Point(754, 97);
            this.nupPhysics.Name = "nupPhysics";
            this.nupPhysics.Size = new System.Drawing.Size(120, 24);
            this.nupPhysics.TabIndex = 11;
            // 
            // nupChemistry
            // 
            this.nupChemistry.Location = new System.Drawing.Point(754, 155);
            this.nupChemistry.Name = "nupChemistry";
            this.nupChemistry.Size = new System.Drawing.Size(120, 24);
            this.nupChemistry.TabIndex = 12;
            // 
            // nupComputerScience
            // 
            this.nupComputerScience.Location = new System.Drawing.Point(754, 202);
            this.nupComputerScience.Name = "nupComputerScience";
            this.nupComputerScience.Size = new System.Drawing.Size(120, 24);
            this.nupComputerScience.TabIndex = 13;
            // 
            // btnCalcGrade
            // 
            this.btnCalcGrade.Location = new System.Drawing.Point(333, 290);
            this.btnCalcGrade.Name = "btnCalcGrade";
            this.btnCalcGrade.Size = new System.Drawing.Size(95, 23);
            this.btnCalcGrade.TabIndex = 14;
            this.btnCalcGrade.Text = "Calculate Grade";
            this.btnCalcGrade.UseVisualStyleBackColor = true;
            this.btnCalcGrade.Click += new System.EventHandler(this.btnCalcGrade_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(474, 290);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // GradeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 749);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcGrade);
            this.Controls.Add(this.nupComputerScience);
            this.Controls.Add(this.nupChemistry);
            this.Controls.Add(this.nupPhysics);
            this.Controls.Add(this.nupMaths);
            this.Controls.Add(this.cmbSemesterSelection);
            this.Controls.Add(this.txtStudentRollNumber);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "GradeCalculator";
            this.Text = "Grade Calculator";
            this.Load += new System.EventHandler(this.GradeCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupMaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPhysics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupChemistry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupComputerScience)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentRollNumber;
        private System.Windows.Forms.ComboBox cmbSemesterSelection;
        private System.Windows.Forms.NumericUpDown nupMaths;
        private System.Windows.Forms.NumericUpDown nupPhysics;
        private System.Windows.Forms.NumericUpDown nupChemistry;
        private System.Windows.Forms.NumericUpDown nupComputerScience;
        private System.Windows.Forms.Button btnCalcGrade;
        private System.Windows.Forms.Button btnClear;
    }
}