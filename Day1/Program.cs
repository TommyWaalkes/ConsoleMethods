using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Please input a valid int");
            string input = Console.ReadLine();
            int num = int.Parse(input);

            Console.WriteLine(num);
            
        }
    }
}
