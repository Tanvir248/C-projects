using System;

namespace LearnCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int[5];
            for (int i=0; i<5; i++)
            {
              arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Written array is: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
