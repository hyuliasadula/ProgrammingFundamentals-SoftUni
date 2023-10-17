﻿using System;

namespace _02_Grades
{
    internal class Program
    {
        /*
         Create a method that receives a grade between 2.00 and 6.00 and prints the corresponding grade definition:
        • 2.00 – 2.99 - "Fail"
        • 3.00 – 3.49 - "Poor"
        • 3.50 – 4.49 - "Good"
        • 4.50 – 5.49 - "Very good"
        • 5.50 – 6.00 - "Excellent"

         */
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            CheckGrade(grade);
        }

        static void CheckGrade(double grade)
        {
            if (grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }


        }
    }
}
