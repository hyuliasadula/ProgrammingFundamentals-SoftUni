using System;

namespace _01_IntegerOperations
{
    internal class Program
    {


        /*
         
         Create a program that receives four integer numbers.
        You should perform the following operations:
        • Add first to the second.
        • Divide (integer) the result of the first operation by the third number.
        • Multiply the result of the second operation by the fourth number.
        Print the result after the last operation.
        Constraints
        • First number will be in the range [-2,147,483,648…2,147,483,647].
        • Second number will be in the range [-2,147,483,648…2,147,483,647].
        • Third number will be in the range [-2,147,483,648…2,147,483,647].
        • Fourth number will be in the range [-2,147,483,648…2,147,483,647].
         

        10
        20
        3
        3

                    30
         
         */
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int addingSum = firstNumber + secondNumber;
            int dividingToTheFirstOperation = addingSum / thirdNumber;
            int multiplyThirdOparationWithFourth = dividingToTheFirstOperation * fourthNumber;

            Console.WriteLine(multiplyThirdOparationWithFourth);
        }
    }
}
