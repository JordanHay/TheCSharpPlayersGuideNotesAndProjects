using System;
namespace TheCSharpPlayersGuidePractice
{
    public class chapterTwentyOne
    {
      

            // STRUCTS AND CLASSES

            struct TimeStruct
        {
            private int seconds;

            public int Seconds
            {
                get { return seconds;  }
                set { seconds = value;  }
            }

            public int CalculateMinutes()                      //structs are value types and classes are reference types
                                                               // a struct uses value semantics instead of reference semantics. when you assign the value
                                                               // of a struct from one variable to another, the entire struct is copied. the same thing
                                                               // appliesfor passing one to a method as a parameter and returning one from a method.
            {
                return seconds / 60;
            }
        }

        class TimeClass
        {
            private int seconds;

            public int Seconds
            {
                get { return seconds; }
                set { seconds / 60; }
            }

            public int CalculateMinutes()
            {
                return seconds / 60;
            }
        }                                                         // lets say we are using the struct version of TimeStruct and added an update time method
                                                      // like this: UpdateTime(time); in the main. we can modify it if we want but this hasnt changed the original version back in the main method.
                                                      // we've modified a copy and the original has a value of 10 for seconds.
                                                      // had we used TimeClass, handing it off to a method copies the reference but that copied reference still points the same actual object.
                                                      // the change in the update time method would have affected the time variable back in the main method. 
        
    }
}
