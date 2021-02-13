using System;

namespace LearnCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter something for string: ");
            string s = Console.ReadLine();
            string s1 = Console.ReadLine();
            Console.WriteLine(s + " " + s1);
            Console.ReadKey();
        }
    }
}
