using System;
using System.Collections.Generic;

namespace HW_2
{
	class Program
	{
		public static int BinarySearch(int[] inputArray, int searchValue)
		{
			int min = 0;
			int max = inputArray.Length - 1;
			while (min <= max)
			{
				int mid = (min + max) / 2;
				if (searchValue == inputArray[mid])
				{
					return mid;
				}
				else if (searchValue < inputArray[mid])
				{
					max = mid - 1;
				}
				else
				{
					min = mid + 1;
				}
			}
			return -1;
		}
		static void Main(string[] args)
		{
			TwoLinkedList list = new TwoLinkedList();
			list.AddNode(10);
			list.AddNode(20);
			list.AddNode(30);
			list.AddNode(40);
			list.AddNode(50);
			list.AddNodeAfter(new Node(33), 20);
			list.FindNode(33);
			list.FindNode(44);
			list.RemoveNode(4);

			int[] array = new int[1000000];
			Random rnd = new();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rnd.Next(156, 952366);
			}
			Array.Sort(array);
			BinarySearch(array, rnd.Next(156, 952366));

		}
	}
}
