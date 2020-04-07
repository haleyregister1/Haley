using System;

namespace OperatorsExercise1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number:");
            int y = int.Parse(Console.ReadLine());

            int sum = x + y;
            int sub = x - y;
            int prod = x * y;
            int quotient = x / y;
            int remain = x % y;

            Console.WriteLine($"The sum of {x} and {y} is: {sum}");
            Console.WriteLine($"The subtraction of {x} and {y} is: {sub}");
            Console.WriteLine($"The product of {x} and {y} is: {prod}");
            Console.WriteLine($"The quotient of {x} and {y} is {quotient} with a remainder of {remain}.");
        }
    }
}
