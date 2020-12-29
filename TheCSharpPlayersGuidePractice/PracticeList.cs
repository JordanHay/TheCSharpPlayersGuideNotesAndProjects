using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheCSharpPlayersGuidePractice
{
    public class PracticeList<T> where T : IComparable
    {
        private T[] items;

        public PracticeListTwo()
        {
            items = new T[0];
        }
        public T GetItem(int index)
        {
            return items[index];
        }
        public void Add(T newItem)
        {
            // make a new bigger array with room to store the new item
            T[] newItems = new T[items.Length + 1];

            // copy all of the old items over to the new array
            for (int index = 0; index < items.Length; index++)
                newItems[index] = items[index];

            //put new items at the end
            newItems[newItems.Length - 1] = newItem;

            //update our instance variable to hold this new array instead of the old array
            items = newItems;
        }
    }
    public class PracticeDictionary<K, V> where K : SomeBaseClass, SomeRandomInterface
                                          where V : SomeOtherInterface
    {

    }
}
