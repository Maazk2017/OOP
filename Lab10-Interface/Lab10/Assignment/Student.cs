using System;

namespace Lab10.Assignment
{
    interface IReportable
    {
        string GenerateReport();
    }
    abstract class Student : IReportable
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Student(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public abstract double CalculateFee();
        public abstract string GenerateReport();
        public void PrintDetails()
        {
            Console.WriteLine("\n===== Student Details =====");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Fee: PKR {CalculateFee():N0}");
            Console.WriteLine(GenerateReport());
        }

    }

    class RegularStudent : Student
    {
        public double TuitionFee { get; set; }

        public RegularStudent(string id, string name, double fee) : base(id, name)
        {
            TuitionFee = fee;
        }

        public override double CalculateFee()
        {
            return TuitionFee;
        }

        public override string GenerateReport()
        {
            return $"Type: Regular Student | Tuition Fee: PKR {TuitionFee:N0}";
        }
    }

    class ScholarshipStudent : Student
    {
        public double TuitionFee { get; set; }
        public double ScholarshipPercentage { get; set; }

        public ScholarshipStudent(string id, string name, double fee, double scholarship) : base(id, name)
        {
            TuitionFee = fee;
            ScholarshipPercentage = scholarship;
        }

        public override double CalculateFee()
        {
            return TuitionFee - (TuitionFee * ScholarshipPercentage / 100);
        }

        public override string GenerateReport()
        {
            return $"Type: Scholarship Student | Scholarship: {ScholarshipPercentage}%";
        }
    }
    class HostelStudent : Student
    {
        public double TuitionFee { get; set; }
        public double HostelFee { get; set; }

        public HostelStudent(string id, string name, double tuitionFee, double hostelFee) : base(id, name)
        {
            TuitionFee = tuitionFee;
            HostelFee = hostelFee;
        }

        public override double CalculateFee()
        {
            return TuitionFee + HostelFee;
        }

        public override string GenerateReport()
        {
            return $"Type: Hostel Student | Hostel Fee: PKR {HostelFee:N0}";
        }
    }
}
