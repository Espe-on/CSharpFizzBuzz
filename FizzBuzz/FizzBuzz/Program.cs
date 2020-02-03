using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTotal = 100;
            int fizzNumber = 3;
            int buzzNumber = 5;
            for (int i= 1; i <= countTotal; i++)
            {
                if ((i % fizzNumber*buzzNumber) == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((i % fizzNumber) == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % buzzNumber) == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}