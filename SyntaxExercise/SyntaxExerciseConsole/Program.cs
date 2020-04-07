using System;

namespace SyntaxExerciseConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;

            string response = answer < 9 ? $"{answer} is less than nine" : $"{answer} greater than or equal to nine";

            // Before:

           /* int answer = 4;
            string response;

            if (answer < 9) ? $”{
                {
                    response = answer + " is less than nine";
                }
            else
                {
                    response = answer + “greater than or equal to nine”;
                }
                */
            }
        }
    }
}
