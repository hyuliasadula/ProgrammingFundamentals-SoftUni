using System;

namespace Lection1
{
    internal class Program
    {
        /*Create a program that receives 3 lines of input:

        · student name
        · age
        · average grade

        Your task is to print all of the info about the student in the following format: "Name: {student name}, Age: {student age}, Grade: {student grade}".
        */
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double avarageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {avarageGrade:f2}");
        }
    }
}
