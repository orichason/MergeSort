using System;

namespace MergeSort
{
    class Program
    {

        static T[] MergeSort<T>(T[] numberList) where T : IComparable
        {
            if (numberList.Length == 1) return numberList;

            T[] array1 = new T[numberList.Length / 2];
            T[] array2 = new T[numberList.Length - array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = numberList[i];
            }

            for (int i = array1.Length; i < numberList.Length; i++)
            {
                array2[i - array1.Length] = numberList[i];
            }

            array1 = MergeSort(array1);
            array2 = MergeSort(array2);



            for (int i = 0, j = 0,count = 0; i < array1.Length || j < array2.Length; count++)
            {
                if (j >= array2.Length || (i < array1.Length && array1[i].CompareTo(array2[j]) == -1))
                {
                    numberList[count] = array1[i];
                    i++;
                }

                else
                {
                    numberList[count] = array2[j];
                    j++;
                }
            }

            return numberList;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numberList = new int[] { 38,27,43,3,9,82,10};

            numberList = MergeSort(numberList);

            ;
        }
    }
}
