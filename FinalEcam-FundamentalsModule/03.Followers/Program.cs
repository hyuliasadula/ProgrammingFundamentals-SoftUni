using System;
using System.Collections.Generic;

namespace _03.Followers
{
    internal class FacebookFollowers
    {
        static void Main()
        {
            Dictionary<string, int[]> followers = new Dictionary<string, int[]>();

            string command = Console.ReadLine();
            while (command != "Log out")
            {
                Commands(command, followers);

                command = Console.ReadLine();
            }

            PrintFollowers(followers);
        }

        static void Commands(string command, Dictionary<string, int[]> followers)
        {
            string[] arguments = command.Split(": ");
            string argumentsAction = arguments[0];

            switch (argumentsAction)
            {
                case "New follower":
                    AddNewFollower(arguments[1], followers);
                    break;

                case "Like":
                    Like(arguments[1], int.Parse(arguments[2]), followers);
                    break;

                case "Comment":
                    Comment(arguments[1], followers);
                    break;

                case "Blocked":
                    Block(arguments[1], followers);
                    break;
            }
        }

        static void AddNewFollower(string username, Dictionary<string, int[]> followers)
        {
            if (!followers.ContainsKey(username))
            { 
                followers.Add(username, new int[] { 0, 0 }); 
            }
                
        }

        static void Like(string username, int count, Dictionary<string, int[]> followers)
        {
            if (!followers.ContainsKey(username))
            {
                followers.Add(username, new int[] { count, 0 });
            }
            else
            {
                followers[username][0] += count;
            }
                
        }

        static void Comment(string username, Dictionary<string, int[]> followers)
        {
            if (!followers.ContainsKey(username))
            {
                followers.Add(username, new int[] { 0, 1 });
            }
            else 
            {
                followers[username][1]++;
            }
                
        }

        static void Block(string username, Dictionary<string, int[]> followers)
        {
            if (followers.ContainsKey(username))
            {
                followers.Remove(username);
            }

            else
            {
                Console.WriteLine($"{username} doesn't exist.");
            }
               
        }

        static void PrintFollowers(Dictionary<string, int[]> followers)
        {
            Console.WriteLine($"{followers.Count} followers");

            foreach (var follower in followers)
            {
                Console.WriteLine($"{follower.Key}: {follower.Value[0] + follower.Value[1]}");
            }
        }
    }
}