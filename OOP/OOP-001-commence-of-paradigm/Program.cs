using System;
using System.Collections.Generic;
using System.IO;

namespace OOP_001_commence_of_paradigm
{
    class Program
    {
        static string pathToFile = @"C:\Users\Alexander\WriteLine.txt";
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            Console.Write("Enter please a command: ");
            string command = Console.ReadLine();//'add-user'
            while (command != "stop")
            {
                //todo: add processing to the programm, adding of users, and search users, 
                //delation of users, as well as sorting, output, 
                //writing of users into a text file. 
                if (command == "add-user")
                {
                    Console.Write("Please enter id of a user: ");
                    User newUser = new User();

                    newUser.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter a name of a user: ");
                    newUser.Name = Console.ReadLine();
                    Console.Write("Please enter an email of a user: ");
                    newUser.Email = Console.ReadLine();
                    Console.Write("Please enter a birth day of a user: ");
                    newUser.BirthDay = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("New user: " + newUser);
                    users.Add(newUser);
                    Console.WriteLine("Size of list is: " + users.Count);
                }
                if (command == "list")
                {
                    Console.WriteLine("Here is a full list of users: ");
                    foreach (var user in users)
                    {
                        Console.WriteLine(user);
                    }


                    
                }
                Console.Write("Enter please a command: ");
                command = Console.ReadLine();
                if (command == "save")
                {
                    string[] usersJson = new string[users.Count];
                    for (int i = 0; i < users.Count; i++)
                    {
                        usersJson[i] = users[i].ToString();
                    }
                    File.WriteAllLines(pathToFile, usersJson);
                
                //todo extract absolute path to a variable and apply it instead of string

                if (command == "read")
                {
                    
                    string[] lines = File.ReadAllLines(pathToFile);

                //todo read about JSON format in C# how it is processed in C#
                }
                   
                

            }
            //todo add writing of users to the text file, read about file input and output in C#.
        }
    }
}
