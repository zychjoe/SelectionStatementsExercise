using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            var r = new Random();
            var favNumber = r.Next(1, 1000);

            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }


            Console.WriteLine("What is your favorite school subject?");
            string userSubj = Console.ReadLine();

            switch(userSubj)
            {
                case "math":
                    Console.WriteLine("Yeah, I like math!");
                    break;
                case "science":
                    Console.WriteLine("Science? You smarty!");
                    break;
                case "french":
                    Console.WriteLine("Maiss oui, bien sur!");
                    break;
                case "history":
                    Console.WriteLine("Huh, not for me...");
                    break;
                case "english":
                    Console.WriteLine("Nah, English is dumb.");
                    break;
                default:
                    Console.WriteLine($"Oh, I forgot about {userSubj}. Cool!");
                    break;

            }

        }
    }
}
