using System;
namespace Lab09.Assignment09
{
    internal class DoctorPatient
    {
        //        Relationship Type: Association
        //        Doctors and patients interact with each other.

        //Neither owns the other.

        //A doctor can treat many patients.
        //A patient can visit many doctors.
    }

    internal class Patient
    {
        public string Name;

        public Patient(string name)
        {
            Name = name;
        }
    }

    internal class Doctor
    {
        public string Name;

        public Doctor(string name)
        {
            Name = name;
        }

        public void TreatPatient(Patient p)
        {
            Console.WriteLine($"{Name} is treating {p.Name}");
        }
    }
}
