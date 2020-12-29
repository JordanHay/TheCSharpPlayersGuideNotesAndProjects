using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotesStartingChEight
{
    public class chEight
    {

        bool b = false;
        int i = Convert.ToInt32(b); // converts a bool to an integer

        double d = 3.4;
        float f = Convert.ToSingle(d); // converts a double to a float. You can convert any built in to another

        // Try it out Cylinders How I did it

        Console.WriteLine("what is the height?");

        var h = Console.ReadLine();

        Console.WriteLine("what is the radius?");

        var r =Console.ReadLine();

        int volumeOfCylinder = 3.1415926 * r * h;
        int surfaceAreaOfCylinder = 2 * 3.1415 * r(r + h);

        Console.WriteLine(volumeOfCylinder);
            Console.WriteLine(surfaceAreaOfCylinder);

            //How Whitaker did it

            Console.Write("Enter the cylinder's radius: ");
            string radiusAsAString = Console.ReadLine();
        double radius = Convert.ToDouble(radiusAsAString);

        Console.Write("enter the cylinder's height: ");
            string heightAsAString = Console.ReadLine();
        double height = Convert.ToDouble(heightAsAString);

        double pi = 3.1415926;
        double volume = pi * radius * radius * height;
        double surfaceArea = 2 * pi * radius * (radius + height);

        Console.WriteLine("The cylinder's volume is " + volume + " cubic units");
            Console.WriteLine("The cylinder's surface area is: " + surfaceArea + "square units");

            Console.ReadKey();

            // incrementing and decrementing
            // a++ means give me the value in a then increment a. while a++ means increment a first then give me the resulting value.

        int a = 3;
        int b = ++a; // both A and B will now be 4

        int c = 3;
        int d = c++; // the original value of 3 is assigned to D, while C is now 4
    }
}
