using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                    User newUser = new User();//create a new instance of the User

                    newUser.Id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter a name of a user: ");
                    newUser.Name = Console.ReadLine();
                    Console.Write("Please enter an email of a user: ");
                    newUser.Email = Console.ReadLine();
                    Console.Write("Please enter a birth day of a user: ");
                    newUser.BirthDay = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("New user: " + newUser);
                    users.Add(newUser);
                    RemoveDuplicate(users);
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

                if (command == "save")
                {
                    string[] usersStrings = new string[users.Count];
                    //[type] [variable-name] = new [type]

                    for (int i = 0; i < users.Count; i++)
                    {
                        usersStrings[i] = users[i].ToString();
                    }
                    File.WriteAllLines(pathToFile, usersStrings);
                }
                if (command == "read")
                {
                    string[] lines = File.ReadAllLines(pathToFile);
                    List<User> readedUsers = new List<User>(lines.Length);
                    foreach (string line in lines)
                    {
                        //2233;sdd;200;12/2/2012 00:00:00 ->
                        //["2233", "sdd", "200", "12/2/2012 00:00:00"]
                        string[] result = line.Split(new char[] { ';' });
                        User newUser = new User();
                        newUser.Id = Convert.ToInt32(result[0]);
                        newUser.Name = result[1];
                        newUser.Email = result[2];
                        newUser.BirthDay = Convert.ToDateTime(result[3]);
                        users.Add(newUser);
                        RemoveDuplicate(users);
                    }
                }
                Console.Write("Enter please a command: ");
                command = Console.ReadLine();
            }
        }

        public static void RemoveDuplicate(List<User> deleteDup)
        {
            //[1,2,2,3,4] - deleteDup
            //[] - uniqueUsers
            //1.currentItem=1, if=true -> uniqueUsers = [1]
            //2.currentItem=2, if=true -> uniqueUsers = [1,2]
            //3.currentItem=2, if=false -> uniqueUsers = [1,2]
            //4.currentItem=3, if=true -> uniqueUsers = [1,2,3]
            //5.currentItem=4, if=true -> uniqueUsers = [1,2,3,4]

            List<User> uniqueUsers = new List<User>();
            foreach (User currentItem in deleteDup)
            {
                if (!uniqueUsers.Contains(currentItem))
                {
                    uniqueUsers.Add(currentItem);

                }
            }
            deleteDup.Clear();
            deleteDup.AddRange(uniqueUsers);
        }
    }
}
