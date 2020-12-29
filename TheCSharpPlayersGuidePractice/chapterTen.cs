using System;
namespace TheCSharpPlayersGuidePractice
{
    public class chapterTen
    {
        public chapterTen()
        {
            // everything up here before the if statement will always be executed.
            int score;

            Console.WriteLine("Enter your score: ");
            string scoreAsText = Console.ReadLine();
            score = Convert.ToInt32(scoreAsText);

            if(score == 100)
            {
                Console.WriteLine("Perfect score! You win! ");
            }
            else if(score == 99)
            {
                Console.WriteLine("You missed it by THAT much."); //get smart reference anyone?
            }
            else if(score == 0)
            {
                Console.WriteLine("You must have been TRYING to get that bad of a score");
            }
            else
            {
                Console.WriteLine("Ah, come on! That's just boring. Next time get a more interesting score.");
            }

            // using bool in decision making

            int scoreTwo = 45;

            int pointsNeededToPass = 100;

            bool levelComplete = (score >= pointsNeededToPass);

            if (levelComplete)
            {
                Console.WriteLine("You've beaten the level! ");


            }


            // even or odd

            int a = 0;
            int b = 0;

            int checkIfEven = a % b;

            Console.WriteLine("what is your first number: ");
            Console.WriteLine("what is your second number: ");

            string numbersGiven = Console.ReadLine();

            if(checkIfEven == 0)
            {
                Console.WriteLine("Your numbers are even!");
            }
            else
            {
                Console.WriteLine("Your numbers are odd!");
            }

            // the conditional operator

            Console.WriteLine((score > 70) ? "You passed!" : "You failed.");


        }
    }
}
