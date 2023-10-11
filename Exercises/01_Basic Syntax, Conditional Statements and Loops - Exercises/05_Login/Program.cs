using System;
using System.Linq;

namespace _05_Login
{
    internal class Program
    {
        /*
         On the first line, you will be given a username and your task is to try to log in the user. The user's password is the username reversed. On the next lines, you will receive passwords:

        · If the password is incorrect, print "Incorrect password. Try again.".

        · If the password is correct, print "User {username} logged in." and stop the program.

        Keep in mind that if the password is still incorrect on the fourth attempt, you should print: "User {username} blocked!".

        Then the program stops.


         
         */
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            //we can use this instead of the forr to reverse a string
           // string password = new string(username.Reverse().ToArray());

            string passwordAttempts = "";
            int passwordAttemptsCounter = 0;

            //reverse a string 
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            
            while (passwordAttempts != password)
            {
                
                passwordAttempts = Console.ReadLine();

                //if the user password is right
                if (passwordAttempts == password) 
                { 
                    Console.WriteLine($"User {username} logged in.");
                    break; 
                }


                //when it reaches 4 triest blockes the user
                passwordAttemptsCounter++;
                
                if (passwordAttemptsCounter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
           
        }
    }
}
