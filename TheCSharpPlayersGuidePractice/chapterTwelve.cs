using System;
namespace TheCSharpPlayersGuidePractice
{
    public class chapterTwelve
    {
        public chapterTwelve()
        {
            //The while loop

            int x = 1;

            while(x <= 10)
            {
                Console.WriteLine(x);
                x++;  // if the x++ wasn't here we would have the glorious infinite loop
            }

            int playersNumber = -1;

            while (playersNumber < 0 || playersNumber > 10)
            {
                // this code will be reapeated until the player types in a number between 0 and 10

                Console.WriteLine("enter a number between 0 and 10: ");
                string playerResponse = Console.ReadLine();
                playersNumber = Convert.ToInt32(playerResponse);  //it is important that we initialize playersNumber to -1 bc if we had started it at 0
                                                                    // the flow of execution would have jumped right over the while loop block and the player would have never been able to
                                                                    // choose a number
            }

            // instead of setting players number to -1 we could just use a do while loop

            do
            {
                Console.WriteLine("Enter a number between 0 and 10: ");
                string playerResponse = Console.ReadLine();
                playersNumber = Convert.ToInt32(playerResponse);
            }
            while (playersNumber < 0 || playersNumber > 10);


            // the for loop

            for(int x = 1; x <= 10; x++)
            {
                Console.WriteLine(x);
            }

            // nesting loops

            for(int row = 0; row < 5; row++)
            {
                for(int column = 0; column < 10; column++)
                {
                    Console.Write("*");

                    Console.WriteLine(); // this makes it wrap around to the beginning of the line.
                }
            }

            /* ^^^^^ produces **********
             *                **********
             *                **********
             */



        }
    }
}
