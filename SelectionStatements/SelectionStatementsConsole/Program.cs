using System;

namespace SelectionStatementsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //if, else-if statement:

              Console.WriteLine("Guess my favorite number!");
              int favNum = int.Parse(Console.ReadLine());
              int num = 8;

              if (favNum < num)
              {
                  Console.WriteLine("Too Low");
              }
              else if (favNum > num)
              {
                  Console.WriteLine("Too High");
              }
              else if (favNum == num)
              {
                  Console.WriteLine("You got it! Pat yourself on the back :)");
              }
              else
              {
                  Console.WriteLine("Nevermind");
              }

            //Switch case:

              string subject = "C#";

              Console.WriteLine("Choose a subject");
              string userSUbject = Console.ReadLine();

              switch (userSUbject)
              {
                case "C#":
                    Console.WriteLine("You're 100% correct!");
                    break;
                case "JavaScript":
                    Console.WriteLine("C# is better than Java");
                    break;
                default:
                    Console.WriteLine("You're learning C#, thats a hint.");
                    break;
              }
        }
    }
}
