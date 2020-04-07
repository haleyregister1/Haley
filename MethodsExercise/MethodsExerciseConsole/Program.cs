using System;

namespace MethodsExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a character:");
            string name = Console.ReadLine();

            Console.WriteLine("Give me a setting:");
            string sett = Console.ReadLine();

            Console.WriteLine("Give me a place to travel:");
            string travel = Console.ReadLine();

            Console.WriteLine("Give me a problem:");
            string prob = Console.ReadLine();

            Console.WriteLine("Give me an adjective:");
            string adj1 = Console.ReadLine();

            Console.WriteLine("Give me another adjective:");
            string adj2 = Console.ReadLine();

            Console.WriteLine("Give me an action to resolve a problem:");
            string resln = Console.ReadLine();

            Console.WriteLine("Give me the result of a solution:");
            string reslt = Console.ReadLine();

            Console.WriteLine($"Once upon a time, {name} Lived in an old and" +
                $" smelly {sett}. He/she wanted to go somewhere exciting, so he/she" +
                $" planned a trip to {travel}. But then, {prob}! {name} was very " +
                $"{adj1} and {adj2}. He/she had to do something! So he/she {resln}." +
                $" After he/she did this, {reslt}. And {name} lived happily ever after.");

        }
    }
}
