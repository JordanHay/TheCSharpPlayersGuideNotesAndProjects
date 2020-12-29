using System;

namespace TheCSharpPlayersGuidePractice
{
    public class chaptersOneThroughSeven
    {
        int number = 3; //uses 4 bytes (32 bits)

        //Three different types of int, storing different number of bytes

        byte aSingleByte = 34;
        short aNumber = 5039;
        long aVeryBigNumber = 395904280669;

        // unsigned ints, which sacrifice negative numbers for double the positive range

        sbyte score = 120;
        ushort thing = 30000;
        uint mabob = 60000;
        ulong bite = 9000000000000000000;

        // char type is used for storing single characters or letters as opposed to numbers

        char favoriteLetter = 'C';

        // floating point numbers are able to store not just integer values but also numbers with a decimal point

        double pi = 3.14159265358979323846;
        float anotherPi = 3.1415926f;

        // sticking the f at the end of a floating point literal tells the compiler to treat it as a literal of the float type instead of the double type

        long aBigNumber = 3953859325820508L; // the L indicates that it is a long literal integer
        ulong bigOne = 2985825802805280508UL; // an unsigned integer literal

        // the decimal type has a small range but much higher precision and must have an M at the end. 

        decimal noomber = 1.495m;


        bool itWorked = true;


        string message = "I'm sorry Dave. I'm afraid I can't do that. ";

        // var is vague and people have strong feelings about it but the compiler will infer the type

        var note = "2001 space odyssey";

        // MATH

        int a;   // declaring the variable A
        a = 9 - 2; // assigning value to A using some math
        a = 3 + 3; // another assignment

        int b = 3 + 1; //declaring and assigning b at once
        b = 1 + 2; // assigning a second value to b

        float totalCost = 22.54f;
        float tipPercent = 0.18f;  // same as 18 percent
        float tipAmount = totalCost * tipPercent;

        int remainder = 20 % 4; //this will be 0, which tells us 20 is a multiple of 4

        // COMPOUND ASSIGNMENT OPERATORS

        int c = 5;
        c -= 3; // this is the same as c = c - 3; at this point c will be 4
        c *= 5; // this is the same as c = c * 5; at this point c will be 20
        c /= 4; // this is the same as c = c / 4; at this point c will be 5
        c %= 2; // this is the same as c = c % 2; at this point c will be 1



    }
}
