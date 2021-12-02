using System;

namespace HW_5
{
	class Program
	{
		static void Main(string[] args)
		{
			BinaryTree tree = new();
			tree.Add(5);
			tree.Add(3);
			tree.Add(8);
			tree.Add(1);
			tree.Add(4);
			tree.Add(7);
			tree.Add(6);
			tree.Add(9);
			tree.Add(2);
			//tree.PrintTree();
			//Console.WriteLine();
			//Console.WriteLine($"Результат обхода дерева в ширину ");
			//tree.BSF(0);
			tree.DSF(0);
		}
	}
}
