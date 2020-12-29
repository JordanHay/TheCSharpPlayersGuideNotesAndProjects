using System;
using System.Collections.Generic;

namespace TheCSharpPlayersGuidePractice
{
    public class GenericList
    {
        private object[] objects;

        public GenericList()
        {
            objects = new object[0];
        }

        public void AddObject(object newObject)
        {
           objects = new object[4] { "Frank", "Bob", "Lisa", "Courtney" };
        }

        public object GetObject(int index)
        {
            return objects[index];
        }

        List<string> listOfStrings = new List<string>();  // list class

      listOfStrings.Add("Hello World"); // add an item

      listOfStrings.Insert(0, "text3"); // allows you to supply the index to add the item at, pushign everything else back.

      string firstItem = listOfStrings.ElementAt(0); // get an item out of the list

        string secondItem = listOfStrings[1];  // get a value
        listOfStrings[0] = "New Value!"; // set a value

            listOfStrings.Clear(); // clear the entire list

            int itemsInList = listOfStrings.Count; // use count not length

        List<int> someNumbersInAList = new List<int>();
        someNumbersInAList.Add(14);
            someNumbersInAList.Add(24);
            someNumbersInAList.Add(37);

            int[] numbersInArray = someNumbersInAList.ToArray();  // converting list into an array

        // we are also able to loop over all the items in a list just like with arrays
        foreach(int number in someNumbersInAList)
            {
                // .....
            }

            List<int> someNumbersInAList = new List<int>() { 14, 24, 37 }; // collection initializer syntax



    }

}
