using System;

namespace LearnCsharp
{
    class Program
    {
        static int method(int num1, int num2) {
            int x;
            if (num1 > num2)
                x = num1;
            else
                x = num2;
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int x = method(a, b);
            Console.WriteLine("Bigger number is : " + x);
            Console.ReadKey();
        }
    }
}
