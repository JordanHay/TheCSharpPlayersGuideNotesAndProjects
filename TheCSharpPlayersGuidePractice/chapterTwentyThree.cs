using System;
namespace TheCSharpPlayersGuidePractice
{
    public class chapterTwentyThree
    {
        // POLYMORPHISM, VIRTUAL METHODS, ABSTRACT CLASSES


    }

    public /*abstract*/ class SearchEngine
    {
        public virtual/* abstract */ string[] Search(string findThis)
        {
            return new string[0]; // I'm terrible at searching... I give up
        }
    }

    class GoogleSearch : SearchEngine
    {
        public override string[] Search(string findThis)
        {
            //google search is of course, way better than 3 hard coded results like this..
            return new string[]
            {
                "Here are some great results.",
                "Aren't they neat?",
                "I found 1.2 billion things, I swear."
            };
        }
    }
}
