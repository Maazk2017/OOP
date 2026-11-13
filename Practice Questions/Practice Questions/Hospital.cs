using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Questions
{
    // Question 5
    using System;
    using System.Collections.Generic;

    // Interface
    public interface ITreatment
    {
        void Diagnose();
    }

    // Base Class (Inheritance)
    public abstract class Staff
    {
        public string Name { get; set; }
        public int StaffID { get; set; }
    }

    // Derived Classes
    public class Doctor : Staff, ITreatment
    {
        // Association
        public List<Patient> Patients { get; set; }

        // Dependency
        public void GenerateBill(BillingSystem billingSystem)
        {
            billingSystem.CreateBill();
        }

        // Interface Implementation
        public void Diagnose()
        {
            Console.WriteLine("Doctor is diagnosing patient.");
        }
    }

    public class Nurse : Staff
    {
        // Association
        public Ward AssignedWard { get; set; }
    }

    public class Patient
    {
        public string Name { get; set; }
    }

    public class BillingSystem
    {
        public void CreateBill()
        {
            Console.WriteLine("Bill generated.");
        }
    }

    // Composition
    public class Hospital
    {
        public List<Ward> Wards { get; set; }

        public Hospital()
        {
            Wards = new List<Ward>();
        }
    }

    public class Ward
    {
        // Association
        public List<Nurse> Nurses { get; set; }

        public Ward()
        {
            Nurses = new List<Nurse>();
        }
    }
}
