using System;

namespace Amen_0001
{
    public class ConsoleUtills
    {
        public static int ReadInt(string message)
        {       
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());    
        }

        public static double ReadDouble (double message)
        {
            Console.WriteLine(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static DateTime ReadDate (string message)
        {
              Console.WriteLine(message);
              return Convert.ToDateTime(Console.ReadLine());
        }

        public static string ReadString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static string ReadString()
        {
            return Console.ReadLine();
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
