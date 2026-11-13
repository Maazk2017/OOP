using System;
class Student
{

    // Auto-property for Name, ID, Section
    public string Name { get; set; }
    public string Section { get; set; }
    public string ID { get; set; }

    // Backing Field
    // with backing field we can perform validation on the value entered as if user
    // enter negative values it will handle it correctly
    private double marks;

    public void DisplayDetails()
    {
        Console.WriteLine("Student Name:" + Name);
        Console.WriteLine("Student ID:" + ID);
        Console.WriteLine("Student Section:" + Section);
        Console.WriteLine("Student Marks:" + EnterMarks);
    }

    

    public double EnterMarks
    {
        get { return marks; }
        set {
            if (value < 0) {
                marks = 0;
            } else
            {
                marks = value;
            }
        }
    }


}
