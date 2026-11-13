using System;
namespace Lab09.Assignment09
{
    internal class UniProf
    {
        // Relationship Type: Aggregation
        // professors can switch uni's
    }

    internal class Professor
    {
        public string Name;

        public Professor(string name)
        {
            Name = name;
        }
    }

    internal class University
    {
        private List<Professor> professors;

        public University()
        {
            professors = new List<Professor>();
        }

        public void AddProfessor(Professor p)
        {
            professors.Add(p);
        }

        public void ShowProfessors()
        {
            Console.WriteLine("Professors:");

            foreach (Professor p in professors)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}
