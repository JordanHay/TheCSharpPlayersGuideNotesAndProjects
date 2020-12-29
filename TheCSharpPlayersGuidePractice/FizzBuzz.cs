using System;
namespace TheCSharpPlayersGuidePractice
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {

            for(int x = 0; x <= 100; x++)
            {
                if(x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (x % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
