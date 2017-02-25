using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_001_commence_of_paradigm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter please a command: ");
            string command = Console.ReadLine();
            while (command != "stop")
            {
                //todo: add processing to the programm, and search users, delation of users, as well as sorting, output, wrting of users into a text file. 
                Console.WriteLine(command);
                command = Console.ReadLine();     
            }
        }
    }
}
