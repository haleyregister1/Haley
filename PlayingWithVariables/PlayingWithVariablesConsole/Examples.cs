using System;

namespace PlayingWithVariablesConsole
{
    class Program
    {
        static void Main(string[] args)
        {//Class Example:
            /*
            //Variable Declarations (name):
            int age;
            string name;

            bool isAlive;

            //Variable Initializations (values):
            age = 20;

            name = "Haley Register";

            isAlive = true;

            Console.WriteLine($"{name} is {age} years old.");
            Console.WriteLine($"Is she alive? {isAlive}");
            */

         //Class Exercise:
            //Variable Declarations (name):

            string firstName;
            int age;
            char favLetter;
            bool funFact;
            double favNumber;
            decimal problem;

            //Variable Initializations (values):

            firstName = "Haley";
            age = 20;
            favLetter = 'Q';
            funFact = true;
            favNumber = 19;
            problem = 4 * 5;

            Console.WriteLine($"My name is {firstName}. I am {age} years old.");
            Console.WriteLine($"My favorite letter is {favLetter}.");
            Console.WriteLine($"True or False, I've had to get a splinter " +
                $"surgically removed from my butt: {funFact}");
            Console.WriteLine($"My favorite number is {favNumber}");
            Console.WriteLine($"4 multiplied by 5 is: {problem}");
        }
    }
}
