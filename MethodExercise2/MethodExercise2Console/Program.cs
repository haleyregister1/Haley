using System;

namespace MethodExercise2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //**int.Parse converts a number in a string into its numerical value**

            Console.WriteLine("Give me a number to add:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to add:");
            int y = int.Parse(Console.ReadLine());

            int sum = Sum(x, y);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number to multiply");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("give me another number to multiply");
            int b = int.Parse(Console.ReadLine());

            int product = Multiply(a, b);
            Console.WriteLine($"The product is: {product}");
        }


        public static int Sum(int x, int y)
        {
            int sum = x + y;

            return sum;
            //OR return x + y;
        }

        public static int Multiply(int a, int b)
        {
            int multiply = a * b; 

            return multiply;
            //OR return a * b;
        }
    }
}
