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
                command = Console.ReadLine();
                if (command == "add-user")
                {
                    Console.WriteLine("Please enter: id of a user.");
                    User newUser = new User();
                    newUser.Id = Convert.ToInt32(Console.ReadLine());                    
                    newUser.Name = Console.ReadLine();
                    newUser.Email = Console.ReadLine();
                    //todo: add BirthDay property 
                    
                    
                }
            
            }

        }
    }
}
