using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
	public class Graph
	{
		public List<Vertex> ListVertex { get; }
		public Graph()
		{
			ListVertex = new List<Vertex>();
		}
		public Vertex AddVertex(string city)
		{
			ListVertex.Add(new Vertex(city));
			return new Vertex();
		}

		public void GetConnectedMatrix()
		{
			for (int i = 0; i < ListVertex.Count; i++)
			{
				for (int j = 0; j < ListVertex.Count; j++)
				{
					Console.Write($"{ListVertex[j].Name,15}");
				}
				Console.WriteLine();
				Console.WriteLine();
			}
			Console.SetCursorPosition(0, 1);
			Console.WriteLine();
			for (int i = 0; i < ListVertex.Count; i++)
			{
				for (int j = 0; j < ListVertex.Count; j++)
				{
					int count = 0;
					foreach (var item in ListVertex[i].Edges)
					{

						if (item.ConnectedVertex.To.Name == ListVertex[j].Name)
						{
							Console.Write($"{item.ConnectedVertex.kilometers,15}");
							break;
						}
						else
						{
							count++;
						}
						if (count == ListVertex[i].Edges.Count)
						{
							Console.Write($"{0,15}");
						}
					}
					if (ListVertex[i].Edges.Count == 0)
					{
						Console.Write($"{0,15}");
					}
				}
				Console.WriteLine();
				Console.WriteLine();
			}
			Console.SetCursorPosition(0, 1);
			for (int n = 0; n < ListVertex.Count; n++)
			{
				Console.WriteLine();
				Console.WriteLine(ListVertex[n].Name);
			}
		}

		public Vertex BSF(Vertex startCity, Vertex finishCity)
		{
			Console.WriteLine("Последовательность шагов метода BSF.");
			Console.WriteLine("Выделенные в кавычки города не добавляються в очередь так как были посещены ранее.");
			List<Vertex> visitedVertex = new();
			Queue<Vertex> que = new();
			que.Enqueue(startCity);
			
			visitedVertex.Add(startCity);
			while (que.Count != 0)
			{
				Console.WriteLine($"Добавляем соседей: {que.Peek().Name}");
				foreach (var item in que.Dequeue().Edges)
				{
					if (item.ConnectedVertex.To == finishCity)
					{
						Console.WriteLine($"\"{item.ConnectedVertex.To.Name}\" пункт найден.");
						return item.ConnectedVertex.To;
					}
					if (!visitedVertex.Contains(item.ConnectedVertex.To))
					{
						visitedVertex.Add(item.ConnectedVertex.To);
						que.Enqueue(item.ConnectedVertex.To);
						Console.WriteLine($"{item.ConnectedVertex.To.Name} ");
					}
					else
					{
						Console.WriteLine($"\"{item.ConnectedVertex.To.Name}\" ");
					}
				}
				Console.WriteLine();
			}
			Console.WriteLine("Пункт не найден, или не имеет ребер. Исследованны все возможные пути.");
			return null;
		}

		public Vertex DSF(Vertex startCity, Vertex finishCity)
		{
			Console.WriteLine("Последовательность шагов метода DSF.");
			List<Vertex> visitedVertex = new();
			Stack<Vertex> stack = new();
			stack.Push(startCity);
			Console.Write($"{startCity.Name} ->");
			visitedVertex.Add(startCity);
			while (stack.Count != 0)
			{
				foreach (var item in stack.Pop().Edges)
				{
					
					if (item.ConnectedVertex.To == finishCity)
					{
						Console.WriteLine($"\"{item.ConnectedVertex.To.Name}\" пункт найден.");
						return item.ConnectedVertex.To;
					}
					if (!visitedVertex.Contains(item.ConnectedVertex.To))
					{
						Console.Write($"{item.ConnectedVertex.To.Name} -> ");
						visitedVertex.Add(item.ConnectedVertex.To);
						stack.Push(item.ConnectedVertex.To);
						break;
					}
				}
			}
			Console.WriteLine("Пункт не найден, или не имеет ребер. Исследованны все возможные пути.");
			return null;
		}
	}
}
