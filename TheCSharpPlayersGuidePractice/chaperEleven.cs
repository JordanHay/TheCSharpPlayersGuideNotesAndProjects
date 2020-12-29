using System;
namespace TheCSharpPlayersGuidePractice
{
    public class chaperEleven
    {
        public chaperEleven()
        {

            int menuChoice = 3;

            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("You chose option number 1");
                    break;
                case 2:
                    Console.WriteLine("You chose option number 2, I like that one too.");
                    break;
                case 3:
                    Console.WriteLine("I can't believe you chose option number 3.");
                    break;
                case 4:
                    Console.WriteLine("You can do better than 4...");
                    break;
                case 5:
                    Console.WriteLine("5? Really? Thats what you went with?");
                    break;
                default:
                    Console.WriteLine("Hey! That wasn't even an option!");
                    break;
            }



            //Try it out: calculator with switch case

            int a = 0;
            int b = 0;

            Console.WriteLine("pick your first number: ");
            Console.WriteLine("pick your second number: ");

            Console.WriteLine("Pick your operation: ");

            string operationChosen = Console.ReadLine();

            switch (operationChosen)
            {
                case 11:
                    Console.WriteLine(a + b);
                    break;
                case 12:
                    Console.WriteLine(a - b);
                    break;
                case 13:
                    Console.WriteLine(a * b);
                    break;
                case 14:
                    Console.WriteLine(a / b);
                    break;
                case 15:
                    Console.WriteLine(a % b);
                    break;
                default:
                    Console.WriteLine("You did something wrong bro");
                    break;
            }
        }
    }
}
