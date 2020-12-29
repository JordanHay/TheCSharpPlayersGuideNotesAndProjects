using System;

namespace CSharpPlayersGuideProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int[] numbers = GenerateNumbers();
            //Reverse(numbers);                      //REVERSING AN ARRAY
            // PrintNumbers(numbers);

            // DieRolling();

            //for(int index = 1; index <= 10; index++)
          //  {
          //      Console.WriteLine(Fibonacci(index));         //Fibonacci
          //  }
            
            Console.ReadLine();


        }

        public static int[] GenerateNumbers()
        {

            int[] numbers = new int[10];
            for(int index = 0; index < 10; index++)
            {
                numbers[index] = index + 1;
            }
            return numbers;
            

        }
        public static void PrintNumbers(int[] numbers)
        {
            for(int index = 0; index < numbers.Length; index++)
            {
                Console.Write(numbers[index] + " ");
            }
            Console.WriteLine();
            
        }
        public static void Reverse(int[] numbers)
        {
            int firstIndex = 0;
            int secondIndex = numbers.Length - 1;

            while(firstIndex < secondIndex)
            {
                int temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;

                firstIndex++;
                secondIndex--;
            }
            
        }

        public static void DieRolling()
        {
            Random random = new Random();

            Console.WriteLine("Type in the number of dice to roll: ");
            int count = Convert.ToInt32(Console.ReadLine());

            int total = 0;

            for(int index=0; index < count; index++)
            {
                int roll = random.Next(6) + 1;
                total += roll;

                if(index != count - 1)
                {
                    Console.Write(roll + "+");
                }
                else
                {
                    Console.Write(roll);
                }
            }

            Console.WriteLine("=" + total);

            Console.ReadLine();
        }

        static ulong Fibonacci(int number)
        {
            if (number == 1) { return 1; }
            if (number == 2) { return 1; }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }

}
