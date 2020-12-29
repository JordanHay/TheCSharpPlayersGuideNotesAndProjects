using System;
namespace TheCSharpPlayersGuidePractice
{

    // enumerations are defined in the namespace

    enum DaysOfTheWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };

    enum MonthsOfTheYear { January=1, February=2, March=3, April=4, May=5, June=6, July=7, August=8, September=9, October=10, November=11, December=12 };


    public class chapterFourteen
    {
        public chapterFourteen()
        {
            // create a new variable of your new type
            DaysOfTheWeek today; // indicate the type and give it a name.

            today = DaysOfTheWeek.Tuesday;

            // use it in an IF statement

            if(today == DaysOfTheWeek.Sunday)
            {
                // whatever code
            }

            // try it out
            Console.WriteLine("Pick a number between 1 and 12: ");
            int monthAsInt = (int)MonthsOfTheYear.April;
            MonthsOfTheYear month = (MonthsOfTheYear)monthAsInt;

            int v = Convert.ToInt32(Console.ReadLine());
            
            
            if(v == 1)
            {
                Console.WriteLine("you chose " + MonthsOfTheYear.January);
            }
            else if(v == 2)
            {
                Console.WriteLine("You chose " + MonthsOfTheYear.February);
            }
        }        // ETC
    }
}
