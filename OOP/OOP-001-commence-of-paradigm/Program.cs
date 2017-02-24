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
                Console.WriteLine(command);
                command = Console.ReadLine();     
            }
        }
    }
}
