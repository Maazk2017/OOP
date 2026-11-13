using Lab07.Assignment07;
using Lab07.Task;

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan("Toyota", "Corolla", "2020", 4);
            CargoTruck c = new CargoTruck("Volvo", "FH16", "2018", 20000);

            Console.WriteLine("Sedan");
            s.DisplayDetails();

            Console.WriteLine();

            Console.WriteLine("CargoTruck");
            c.DisplayDetails();

            //Faculty f = new Faculty("faculty@gmail.com", "123");
            //Student s = new Student("student@gmail.com", "456");

            //Console.WriteLine("Faculty");
            //f.AddExam();
            //f.AddGrade();
            //f.ShowInfo();

            //Console.WriteLine();

            //Console.WriteLine("Student");
            //s.AttemptExam();
            //s.ViewGrade();
            //s.ShowInfo();

        }
    }
}
