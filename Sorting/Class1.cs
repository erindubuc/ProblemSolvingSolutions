using System;

namespace Sorting
{
    public class BubbleSortMethod
    {
        void Swap(int[] items, int firstIndex, int secondIndex)
        {
            int temp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = temp;
        }

        int[] BubbleSort(int[] items)
        {

            int len = items.Length;

            for (int indexOfItems = 0; indexOfItems < len; indexOfItems++)
            {
                for (int startIndex = 0, stop = len - startIndex; startIndex < stop - 1; startIndex++)
                {
                    if (items[startIndex] > items[startIndex + 1])
                    {
                        Swap(items, startIndex, startIndex + 1);
                    }
                }
            }

            return items;
        }

    }
}
