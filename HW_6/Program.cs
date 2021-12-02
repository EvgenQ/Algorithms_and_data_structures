using System;

namespace HW_6
{
	class Program
	{
		static void Main(string[] args)
		{
			BinaryTree tree = new();
			//tree.Add(5);
			//tree.Add(3);
			//tree.Add(8);
			//tree.Add(1);
			//tree.Add(4);
			//tree.Add(7);
			//tree.Add(6);
			//tree.Add(9);
			//tree.Add(2);
			//tree.PrintTree();
			//Console.WriteLine();
			//Console.WriteLine($"Результат обхода дерева в ширину ");
			//tree.BSF(0);
			//tree.DSF(0);
			Graph graph = new Graph();
			graph.AddVertex("Moskow");
			graph.AddVertex("Omsk");
			graph.AddVertex("Chelyabinsk");
			graph.AddVertex("Kursk");
			graph.AddVertex("Rostov");
			graph.AddVertex("Kostroma");
			graph.AddVertex("Vladimir");
			graph.AddVertex("NoName");// вершина не имеющая ребер


			graph.ListVertex[0].Edges.Add(new Edge((graph.ListVertex[1], 150)));
			graph.ListVertex[0].Edges.Add(new Edge((graph.ListVertex[2], 400)));
			graph.ListVertex[1].Edges.Add(new Edge((graph.ListVertex[3], 246)));
			graph.ListVertex[1].Edges.Add(new Edge((graph.ListVertex[4], 278)));
			graph.ListVertex[1].Edges.Add(new Edge((graph.ListVertex[0], 150)));
			graph.ListVertex[2].Edges.Add(new Edge((graph.ListVertex[4], 128)));
			graph.ListVertex[2].Edges.Add(new Edge((graph.ListVertex[5], 46)));
			graph.ListVertex[2].Edges.Add(new Edge((graph.ListVertex[0], 400)));
			graph.ListVertex[3].Edges.Add(new Edge((graph.ListVertex[1], 246)));
			graph.ListVertex[3].Edges.Add(new Edge((graph.ListVertex[6], 99)));
			graph.ListVertex[4].Edges.Add(new Edge((graph.ListVertex[1], 278)));
			graph.ListVertex[4].Edges.Add(new Edge((graph.ListVertex[6], 75)));
			graph.ListVertex[4].Edges.Add(new Edge((graph.ListVertex[2], 128)));
			graph.ListVertex[4].Edges.Add(new Edge((graph.ListVertex[5], 88)));
			graph.ListVertex[5].Edges.Add(new Edge((graph.ListVertex[2], 46)));
			graph.ListVertex[5].Edges.Add(new Edge((graph.ListVertex[4], 88)));
			graph.ListVertex[6].Edges.Add(new Edge((graph.ListVertex[3], 99)));
			graph.ListVertex[6].Edges.Add(new Edge((graph.ListVertex[4], 75)));
			graph.GetConnectedMatrix();
			Console.WriteLine();
			Console.WriteLine();
			graph.BSF(graph.ListVertex[0], graph.ListVertex[7]);
			Console.WriteLine();
			graph.BSF(graph.ListVertex[0], graph.ListVertex[6]);
			Console.WriteLine();
			Console.WriteLine();
			graph.DSF(graph.ListVertex[0], graph.ListVertex[7]);
			Console.WriteLine();
			graph.DSF(graph.ListVertex[0], graph.ListVertex[6]);
		}
	}
}
