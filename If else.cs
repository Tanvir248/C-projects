using System;

namespace LearnCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1: ");
            int  num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
           if(num1 > num2)
            {
                Console.WriteLine("Number 1 is greater."+ num1);
            }
            else
            {
                Console.WriteLine("Number 2 is greater."+ num2);
            }
            Console.ReadKey();
        }
    }
}
