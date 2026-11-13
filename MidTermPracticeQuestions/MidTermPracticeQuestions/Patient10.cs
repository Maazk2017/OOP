using System;

namespace MidTermPracticeQuestions
{
    internal class Patient10
    {
        public string Name;
        public int Age;

        public virtual double CalculateBill()
        {
            return 0;
        }

        public virtual void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }

    }

    class IndoorPatient : Patient10
    {
        public double RoomCharges;
        public double TreatmentCharges;

        public override double CalculateBill()
        {
            return RoomCharges + TreatmentCharges;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Room Charges: " + RoomCharges);
            Console.WriteLine("Treatment Charges: " + TreatmentCharges);
            Console.WriteLine("Total Bill (Indoor): " + CalculateBill());
        }
    }

    class OutdoorPatient : Patient10
    {
        public double ConsultationFee;
        public double MedicineCharges;

        public override double CalculateBill()
        {
            return ConsultationFee + MedicineCharges;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Consultation Fee: " + ConsultationFee);
            Console.WriteLine("Medicine Charges: " + MedicineCharges);
            Console.WriteLine("Total Bill (Outdoor): " + CalculateBill());
        }
    }

}
