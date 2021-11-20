using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace HW_4
{
	class Program
	{
		static void Main(string[] args)
		{
			//Random rnd = new();
			//BinaryTree tree = new();
			//tree.Add(5);
			//tree.Add(3);
			//tree.Add(8);
			//tree.Add(1);
			//tree.Add(4);
			//tree.Add(7);
			//tree.Add(6);
			//tree.Add(9);
			//tree.Add(2);
			//tree.Find(9);
			//tree.PrintTree();
			//tree.Delete(7);
			//Console.Clear();
			//tree.PrintTree();

			// Остается вопрос если в дереве присутствуют дублированные элементы то как проводить удаление?
			// И в какую сторону идти если добавляемый элемент равен одному из узлов?

			BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
			// Не уверен что бенчмарк работает правильно
		}

	}

	public class Bencmark
	{
		public class MyHashSet 
		{
			public string Name { get; set; }

			public override bool Equals(object obj)
			{
				MyHashSet set = obj as MyHashSet;
				return Name.CompareTo(set.Name) == 0;
			}
			public override int GetHashCode()
			{
				return Name.Length * 10;
			}
		}
		public HashSet<MyHashSet> Sets { get; set; } = FillHashSet();
		public string[] ArraySets { get; set; } = FillArray();

		public static HashSet<MyHashSet> FillHashSet() 
		{
			HashSet<MyHashSet> testHashSet = new HashSet<MyHashSet>();
			for (int i = 0; i < 9999; i++)
			{
				if (i == 9999) 
				{
					MyHashSet sets = new() { Name = "Barbara" };
					testHashSet.Add(sets);
				}
				else
				{
					MyHashSet sets = new() { Name = Guid.NewGuid().ToString() };
					testHashSet.Add(sets);
				}
			}
			return testHashSet;
		}
		public static string[] FillArray() 
		{
			string[] testArray = new string[9999];
			for (int i = 0; i < testArray.Length; i++)
			{
				if (i == 9999) 
				{
					testArray[i] = "Barbara";
				}
				else
				{
					testArray[i] = Guid.NewGuid().ToString();
				}
				
			}
			return testArray;
		}
		public bool Find_A_PairInAnHashSet(HashSet<MyHashSet> sets, string searchValue) 
		{
			foreach (var item in sets)
			{
				if (item.Name == searchValue) 
				{
					return true;
				}
			}
			return false;
		}
		public bool Find_A_PairInAnArray(string[] arr,string searchValue) 
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i].Contains(searchValue)) 
				{
					return true;
				}
			}
			return false;
		}

		[Benchmark(Description = "Тест массива")]
		public void Test1() 
		{
			Find_A_PairInAnArray(ArraySets, "Barbara");
		}

		[Benchmark(Description = "Тест Хешсета")]
		public void Test2() 
		{
			Find_A_PairInAnHashSet(Sets, "Barbara");
		}

	}
}
