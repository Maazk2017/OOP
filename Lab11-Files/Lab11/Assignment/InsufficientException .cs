using System;

namespace Lab11.Assignment
{
    internal class InsufficientMarksException : Exception
    {
        public string StudentName { get; }
        public int ObtainedMarks { get; }

        public InsufficientMarksException(string name, int marks)
            : base("Evaluation failed: " + name + " did not pass (Marks: " + marks + ").")
        {
            StudentName = name;
            ObtainedMarks = marks;
        }
    }
}