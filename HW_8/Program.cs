using System;
using System.Collections.Generic;

namespace HW_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[13];
			Random rnd = new();
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(1, 100);
			}
			List<int> b = BucketSort(arr);
            b.ForEach(n => Console.Write($"{n} "));
        }

        static List<int> BucketSort(int[] array, int bucketsNumber = 10)
        {
            List<int> sortedArray = new List<int>();
            List<int>[] buckets = new List<int>[bucketsNumber];
            for (int i = 0; i < bucketsNumber; i++)
                buckets[i] = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                int bucket = array[i] / bucketsNumber;
                buckets[bucket].Add(array[i]);
            }
			foreach (var item in buckets)
			{
                sortedArray.AddRange(item);
            }
            sortedArray.Sort();
            return sortedArray;
        }
    }
}
