using System;
namespace TheCSharpPlayersGuidePractice
{
    public class chapterFifteen
    {
        public chapterFifteen()
        {

            int usersNumber = GetNumberFromUser();

            // METHODS 
            static void CountToTen()
            {
                for (int index = 1; index <= 10; index++)
                    Console.WriteLine(index);

                // in static void main in program you would call this method with CountToTen();
                
            }
            // using a method that returns something, eg not static
            static int GetNumberFromUser()
            {
                int usersNumber = 0;
                while(usersNumber < 1 || usersNumber > 10)
                {
                    Console.WriteLine("enter a number between 1 and 10: ");
                    string usersResponse = Console.ReadLine();
                    usersNumber = Convert.ToInt32(usersResponse);
                }
                return usersNumber;
            }

            static int CalculatePlayerScore()
            {
                int livesLeft = 3;
                int underlingsDestroyed = 17;
                int minionsDestroyed = 4;
                int bossesDestroyed = 1;

                // if player runs out of lives, they lose all of their points
                if (livesLeft == 0)
                    return 0;

                //otherwise the player gets 10 points per underling destroyed, 100 pts per minon, and 1000 pts per boss.
                return underlingsDestroyed * 10 + minionsDestroyed * 100 + bossesDestroyed * 1000;
            }

        }/// <summary>
        ///  XML DOCUMENTAION COMMENTS
        ///
        /// </summary>
    }
}
