using System;

namespace CalculateFibonacciValuePosition
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();

            Console.Write("Enter a Fibonacci sequence position: ");

            if (int.TryParse(Console.ReadLine(), out int position))
            {
                Console.WriteLine($"Fibonacci position value is:  {fibonacci.CalculateFibonacci(position)}");
            }
            else
            {
                Console.WriteLine("Position is not a number.");
            }
        }
    }
}
