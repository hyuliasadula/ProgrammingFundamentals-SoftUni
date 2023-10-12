using System;
using System.Linq;

namespace _03_Zig_ZagArrays
{
    internal class Program
    {
        /*
         Create a program that creates 2 arrays. You will be given an integer n. On the next n lines, you will get 2 integers.
        Form 2 new arrays in a zig-zag pattern as shown below.


        input              output
        4
        1 5             1 10 31 20
        9 10            5 9 81 41
        31 81
        41 20
                                    
                                    


        2
        80 23           80 19
        31 19           23 31
                                    
                                    

         
         */
        static void Main(string[] args)
        {
            //how many lines do we want it to have
            int numOfLines = int.Parse(Console.ReadLine());
            //the arrays we will save for the results
            string[] firstArr = new string[numOfLines];
            string[] secondArr = new string[numOfLines];

            
            bool isFirstArrSelected = true;


            for (int i = 0; i < numOfLines; i++)
            {
                //we get the numbers that will be in the array
                string numbers = Console.ReadLine();
                //when we get the line of numbers we split them so we can use them later
                string[] numbersArray = numbers.Split();

                // by default the isFirstArrSelected = true so for the first loop we will go inside of the if
                if (isFirstArrSelected)
                {
                    firstArr[i] = numbersArray[0];
                    secondArr[i] = numbersArray[1];
                }
                else 
                {
                    firstArr[i] = numbersArray[1];
                    secondArr[i] = numbersArray[0];
                }
                //here we change the isFirstArrSelected so that we can enter the else next time
                isFirstArrSelected = ! isFirstArrSelected;
            }
            //and the result is shown here using Join
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
