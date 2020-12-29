using System;
namespace TheCSharpPlayersGuidePractice
{
    public class chapterThirteen
    {
        public chapterThirteen()
        {

            // initializing arrays in different ways

            int[] scores = new int[10] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

            // when you initialize an array this way you do not need to state the number of items in the array
            // like so:  int[] scores = new int[] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };

            // you can also leave off the type since its inferred
            // like this:             int[] scores = new [] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 };


            // 0 based indexing
            int fourthScore = scores[3];
            int eighthScore = scores[7];

            // using the length property to find length of an array

            int totalThingsInArray = scores.Length;
            Console.WriteLine("There are " + totalThingsInArray + " things in the array.");

            // minimum value in an array

            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentMinimum = Int32.MaxValue; // we start high, so that any element in the array will be lower.

            for(int index = 0; index < array.Length; index++)
            {
                if (array[index] < currentMinimum)
                    currentMinimum = array[index];
            }
            // at this point, current minimum contains the minimum value in the array.


            // average value in an array

            int[] flarray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int flatotal = 0;

            for (int index = 0; index < array.Length; index++)
                totalThingsInArray += array[index];

            float average = (float)totalThingsInArray / array.Length;

            // one way to make an array of arrays (or matrix) is to do the following:

            int[][] matrix = new int[4][];
            matrix[0] = new int[4];
            matrix[1] = new int[5];
            matrix[2] = new int[2];
            matrix[3] = new int[6];
            matrix[2][1] = 7;


            // multi dimensional array, to do this put multiple indices inside of one oset of square brackets like so:
            int[,] matrix3 = new int[4, 4];
            matrix3[0, 1] = 1;
            matrix3[0, 1] = 0;
            matrix3[3, 3] = 1;

            //Jagged array

            int[][] matrix = new int[4, 4];
            matrix[0] = new int[2];
            matrix[1] = new int[6];
            // continue filling in values for the jagged array...

            for(int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                    Console.WriteLine(matrix[row][column] + " ");

                Console.WriteLine(); //rows seperated by lines
            }

            // or with the multidimensional array

            int[,] matrixTwo = new int[4, 4];
            // fill in contents for multi dimensional array

            //note: getLength gives back the size of the multi dimensional array for a specific index
            for(int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                    Console.Write(matrix[row, column] + " ");

                Console.WriteLine();
            }

            // FOREACH

            int[] scores = new int[10];

            foreach (int score in scores)
            {
                Console.WriteLine("someone had this score: " + score);
            }

            // if you need to know what index you're at its best to use the for loop:

            int[] scoress = new int[10];
            for(int index = 0; index < scoress.Length; index++)
            {
                int score = scoress[index];
                Console.WriteLine("score number " + index + ":" + score);
            }
        }
    }
}
