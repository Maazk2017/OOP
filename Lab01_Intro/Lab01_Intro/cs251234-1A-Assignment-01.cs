using System;

namespace Lab01_Intro
{
    internal class cs251234_1A_Assignment_01
    {

    }

    class Question1
    {   
        public void GenerateOuptut()
        {
            Console.WriteLine("\t\t\t\t\t- - - - - - - - - - - - - - - - - -");
            Console.WriteLine("\t\t\t\t\t\tDHA SUFFA UNIVERSITY");
            Console.WriteLine("\t\t\t\t\t- - - - - - - - - - - - - - - - - -");
            Console.WriteLine("\t\t\t\t\t\t     Transcript");

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
                " - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Name = Your Name \t\t\t\t\t\t\t\t Roll no. " +
                "= Your Roll Number");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - " +
                "- - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Subject \t\t\t\t\t\t\t\t\t Marks");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
                " - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Programming Fundamentals \t\t\t\t\t\t\t 98");
            Console.WriteLine("Programming Fundamentals Lab \t\t\t\t\t\t\t 93");
            Console.WriteLine("Applied Physics \t\t\t\t\t\t\t\t 84");
            Console.WriteLine("English \t\t\t\t\t\t\t\t\t 93");
            Console.WriteLine("Calculus \t\t\t\t\t\t\t\t\t 87");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
                " - - - - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Percentage =  \t\t\t\t\t\t\t\t\t 90.0%");
            Console.WriteLine("Cgpa =  \t\t\t\t\t\t\t\t\t 4.0");
        }
    }

    class Question2
    {
        public void Format()
        {
            byte val1 = 52;
            byte val2 = 130;
            sbyte val3 = -115;
            int val4 = 4825932;
            byte val5 = 97;
            short val6 = -10000;
            ushort val7 = 20000;
            byte val8 = 224;
            int val9 = 970700000;
            byte val10 = 112;
            sbyte val11 = -44;
            int val12 = -1000000;
            short val13 = 1990;
            long val14 = 123456789123456789L; 

            
            Console.WriteLine("\n{0,-20} {1,20}", "Variable Name", "Value");
            Console.WriteLine("-------------------------------------------");


            Console.WriteLine("{0,-20} | {1,25}", "byte", val1);
            Console.WriteLine("{0,-20} | {1,25}", "byte", val2);
            Console.WriteLine("{0,-20} | {1,25}", "sbyte", val3);
            Console.WriteLine("{0,-20} | {1,25:N0}", "int", val4);
            Console.WriteLine("{0,-20} | {1,25}", "byte", val5);
            Console.WriteLine("{0,-20} | {1,25:N0}", "short", val6);
            Console.WriteLine("{0,-20} | {1,25:N0}", "ushort", val7);
            Console.WriteLine("{0,-20} | {1,25}", "byte", val8);
            Console.WriteLine("{0,-20} | {1,25:N0}", "int", val9);
            Console.WriteLine("{0,-20} | {1,25}", "byte", val10);
            Console.WriteLine("{0,-20} | {1,25}", "sbyte", val11);
            Console.WriteLine("{0,-20} | {1,25:N0}", "int", val12);
            Console.WriteLine("{0,-20} | {1,25:N0}", "short", val13);
            Console.WriteLine("{0,-20} | {1,25:N0}", "long", val14);

            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
