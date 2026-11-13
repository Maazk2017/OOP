using System;
using System.Collections.Generic;
using System.Text;
namespace Lab11
{
    internal class Employee
    {
        public string EmployeeID { get; set; }

        public void SetEmployeeID(string id)
        {
            if (id.Length != 8)
            {
                throw new InvalidEmployeeIDException($"The Employee ID '{id}' must be exactly 8 characters long.");
            }

            if (id.Substring(0, 4) != "EMP-")
            {
                throw new InvalidEmployeeIDException($"The Employee ID '{id}' must start with 'EMP-'.");
            }

            string numeric = id.Substring(4);
            foreach(char c in numeric)
            {
                if (!char.IsDigit(c))
                {
                    throw new InvalidEmployeeIDException($"The last 4 characters of '{id}' must be digits.");
                }
            }

            EmployeeID = id;
            Console.WriteLine($"Employee ID '{id}' successfully set!");
        }
    }
}
