using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are going to play Fizz Buzz!");
            Console.WriteLine("What Number is Fizz?");
            int fizzNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What Number is Buzz?");
            int buzzNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What Number are we going up to?");
            int countTotal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fizz is " + fizzNumber + ", Buzz is " + buzzNumber);
            Console.WriteLine("We are going up to " + countTotal);
            Console.WriteLine("Press Enter to play");
            Console.ReadLine(); 
            // int countTotal = 100;
           // int fizzNumber = 3;
           // int buzzNumber = 5;
            for (int i= 1; i <= countTotal; i++)
            {
                if ((i % fizzNumber) == 0 && (i % buzzNumber) == 0)
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