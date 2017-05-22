using Amen_0001;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OOP_001_commence_of_paradigm
{
    class Program
    {
        static List<User> users = new List<User>();

        static string pathToFile = @"C:\Users\Alexander\WriteLine.txt";
        static void Main(string[] args)
        {
            
            string command = ConsoleUtills.ReadString("Enter please a command: ");//'add-user'
            while (command != "stop")
            {
                //todo: add processing to the programm, adding of users, and search users, 
                //delation of users, as well as sorting, output, 
                //writing of users into a text file. 
                if (command == "add-user")
                {
                    AddUser();
                }
                if (command == "list")
                {
                    ConsoleUtills.PrintMessage("Here is a full list of users: ");
                    foreach (var user in users)
                    {
                        ConsoleUtills.PrintMessage(user.ToString());
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
                ConsoleUtills.PrintMessage("Enter please a command: ");
                command = ConsoleUtills.ReadString();
            }
        }

        private static void AddUser()
        {
            User newUser = new User();//create a new instance of the User

            newUser.Id = ConsoleUtills.ReadInt("Please enter id of a user: ");
            newUser.Name = ConsoleUtills.ReadString("Please enter a name of a user: ");
            newUser.Email = ConsoleUtills.ReadString("Please enter an email of a user: ");
            newUser.BirthDay = ConsoleUtills.ReadDate("Please enter a birth day of a user: ");
            ConsoleUtills.PrintMessage("New user: " + newUser);
            users.Add(newUser);
            RemoveDuplicate(users);
            ConsoleUtills.PrintMessage("Size of list is: " + users.Count);
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
