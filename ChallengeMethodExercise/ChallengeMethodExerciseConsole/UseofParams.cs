using System;

namespace ChallengeMethodExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int Sum(params int[] list)
        //first element of an array is 0, like enum
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
            //allows you to 
        }
    }
}
