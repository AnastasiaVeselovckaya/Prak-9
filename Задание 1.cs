using System;

namespace Задание1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 80; i > 9; i = i - 2)
                Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}