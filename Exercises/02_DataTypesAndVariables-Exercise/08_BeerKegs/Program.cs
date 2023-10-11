using System;

namespace _08_BeerKegs
{
    internal class Program
    {
        /*Create a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines. Every three lines
        will hold information for a single keg. First up is the model of the keg, after that is the radius of the keg, and lastly is
        the height of the keg.
        Calculate the volume using the following formula: π * r^2 * h.
        In the end, print the model of the biggest keg
        


        input          output
         3
        Keg 1           Keg 2
        10
        10
        Keg 2
        20
        20
        Keg 3
        10
        30
         */
        static void Main(string[] args)
        {
            int interval = int.Parse(Console.ReadLine());
            string model = "";
            const double mathPi = Math.PI;

            float maxVolume = float.MinValue; // Initialize to the smallest possible value
            string maxVolumeModel = "";

            for (int i = 0; i < interval; i++)
            {
                model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                //summing the value using       π * r^2 * h
                float volume = (float)mathPi*(radius  *radius) * height;


                //if the volume is bigger that the maxVolume the the maxVolume gets the volume and model name data 
                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    maxVolumeModel = model;
                }
            }
            Console.WriteLine(maxVolumeModel);
        }
    }
}
