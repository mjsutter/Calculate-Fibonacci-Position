using System;

namespace CalculateFibonacciValuePosition
{
    public class Fibonacci
    {
        public int CalculateFibonacci(int position)
        {
            if (position <= 0)
            {
                return 0;
            }
            else if (position == 1)
            {
                return 1;
            }
            else
            {
                return CalculateFibonacci(position - 1) + CalculateFibonacci(position - 2);
            }
        }
    }

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
