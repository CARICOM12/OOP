using System;
using System.Collections.Generic;
using System.IO;

namespace ContactManager
{
    class Program
    {
        static List<User> users = new List<User>();
      
        static string pathToFile = @"C:\Users\Alexander\WriteLine.txt";

        static void Main(string[] args)
        {
            int commandNumber = ShowCommandMessage();
            Commands command = (Commands)commandNumber;
            while  (command != Commands.Stop)
            {
                //todo: add processing to the programm, adding of users, and search users, 
                //delation of users, as well as sorting, output, 
                //writing of users into a text file. 

                switch (command)
                {
                    case Commands.AddUser:
                        AddUser();
                        break;
                    case Commands.List:
                        PrintUsers();
                        break;
                    case Commands.Save:
                        SaveToFile();
                        break;
                    case Commands.Read:
                        LoadAllUsersFromFile();
                        break;
                }
                ShowCommandMessage();
                command = (Commands)commandNumber;
            }

            //Please, select the command: 
            //
        }

        private static int ShowCommandMessage()
        {
            var commands = Enum.GetValues(typeof(Commands));
            string requestMessage = "Enter please a command ";
            ConsoleUtills.PrintMessage("List of available commands: ");
            foreach (var command in commands)
            {
                ConsoleUtills.PrintMessage( (int) command + " " + (Commands) command);
            }
            return ConsoleUtills.ReadInt(requestMessage);
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

        private static void PrintUsers()
        {
            ConsoleUtills.PrintMessage("Here is a full list of users: ");
            foreach (var user in users)
            {
                ConsoleUtills.PrintMessage(user.ToString());
            }
        }

        private static void SaveToFile()
        {
            string[] usersStrings = new string[users.Count];
            //[type] [variable-name] = new [type]

            for (int i = 0; i < users.Count; i++)
            {
                usersStrings[i] = users[i].ToString();
            }
            File.WriteAllLines(pathToFile, usersStrings);
        }

        private static void LoadAllUsersFromFile()
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
