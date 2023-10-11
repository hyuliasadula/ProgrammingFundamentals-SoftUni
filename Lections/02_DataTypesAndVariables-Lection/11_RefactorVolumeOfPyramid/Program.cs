using System;

namespace _11_RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length, width, height = 0;

            length = double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());

            height = (length * width * height)/3;
            Console.Write($"Length: Width: Height: Pyramid Volume: {height:f2}");

            
        }
    }
}
