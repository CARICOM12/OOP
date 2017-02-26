using System;

namespace OOP_001_commence_of_paradigm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter please a command: ");
            string command = Console.ReadLine();//'add-user'
            while (command != "stop")
            {
                //todo: add processing to the programm, adding of users, and search users, 
                //delation of users, as well as sorting, output, 
                //wrting of users into a text file. 
                Console.WriteLine(command);
                if (command == "add-user")
                {
                    Console.WriteLine("Please enter: id of a user.");
                    User newUser = new User();
                    
                    newUser.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter a name of a user: ");                  
                    newUser.Name = Console.ReadLine();
                    Console.WriteLine("Please enter an email of a user: ");
                    newUser.Email = Console.ReadLine();
                    Console.WriteLine("Please enter a birth day of a user: ");
                    newUser.BirthDay = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("New user: " + newUser);

                                           
                }
                command = Console.ReadLine();
            }

        }
    }
}
