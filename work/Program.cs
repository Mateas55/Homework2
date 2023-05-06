using System;

namespace work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("mate bregvadze");
            Console.WriteLine("enter your username");
            var username = Console.ReadLine();           
            Console.WriteLine(Console.ReadLine());
            Console.WriteLine("your user name is " + username);

        }
    }
}
