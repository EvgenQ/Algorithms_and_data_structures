using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW_5
{
	class BinaryTree
	{
		public int Count { get; set; }
		public TreeNode Root { get; set; }

		public void Add(int value)
		{
			TreeNode child = new(value);
			if (Root == null)
			{
				Root = child;
				Count++;
			}
			else
			{
				AddN(Root, value);
			}
		}

		private TreeNode AddN(TreeNode root, int value)
		{
			if (root.Value < value)
			{
				if (root.Right == null)
				{
					root.Right = new(value);
					Count++;
					return root;
				}
				else
				{
					AddN(root.Right, value);
				}
			}
			else
			{
				if (root.Left == null)
				{
					root.Left = new(value);
					Count++;
					return root;
				}
				else
				{
					AddN(root.Left, value);
				}
			}
			return root;
		}
		public void PrintTree()
		{
			Print(Root, 5, 1);
		}
		private int Print(TreeNode node, int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(node.Value);
			Thread.Sleep(125);

			var loc = y;

			if (node.Right != null)
			{
				Console.SetCursorPosition(x + 1, y);
				Console.Write("--");
				Thread.Sleep(125);
				y = Print(node.Right, x + 3, y);
			}

			if (node.Left != null)
			{
				while (loc <= y)
				{
					Console.SetCursorPosition(x, loc + 1);
					Console.Write("|");
					Thread.Sleep(125);
					loc++;
				}
				y = Print(node.Left, x, y + 2);
			}

			return y;
		}
		public void BSF(int searchValue) 
		{
			BSF(Root, searchValue);
		}
		private TreeNode BSF(TreeNode node, int searchValue) 
		{
			Queue<TreeNode> que = new();
			que.Enqueue(node);
			while (que.Count != 0)
			{
				TreeNode newNode = que.Dequeue();
				if (newNode.Value == searchValue) 
				{
					Console.WriteLine($"Элемент {searchValue} найден");
					return newNode;
				}
				if (newNode.Left != null) 
				{
					Console.WriteLine($"Add left element {newNode.Left.Value} in Queue");
					que.Enqueue(newNode.Left);
				}
				if (newNode.Right != null)
				{
					Console.WriteLine($"Add Right element {newNode.Right.Value} in Queue");
					que.Enqueue(newNode.Right);
				}
			}
			Console.WriteLine("Элемент не найден");
			return null;
		}
		public void DSF(int searchValue) 
		{
			DSF(Root,searchValue);
		}

		private TreeNode DSF(TreeNode node, int searchValue)
		{
			Stack<TreeNode> stack = new();
			stack.Push(node);
			Console.WriteLine($"Добавляем в стэк корень {node.Value}");
			node.Visited = true;
			while (node.Value != searchValue)
			{
				Thread.Sleep(100);
				if (node.Value == searchValue) 
				{
					Console.WriteLine($"Значение {searchValue} найдено");
					return node;
				}
				if (node.Left != null && !node.Left.Visited)
				{
					while (node.Left != null)
					{
						node = node.Left;
						node.Visited = true;
						stack.Push(node);
						Console.WriteLine($"Добавляем в стэк левое поддерево {node.Value}");
					}
				}
				else if (node.Right != null && !node.Right.Visited)
				{
					node = node.Right;
					node.Visited = true;
					stack.Push(node);
					Console.WriteLine($"Добавляем в стэк правое поддерево {node.Value}");
				}
				else if (node.Left == null && node.Right == null)
				{
					if (stack.Count == 0) 
					{
						break;
					}
					node = stack.Pop();
					Console.WriteLine($"Удаляем из стэка посещенное поддерево {node.Value}");
				}
				else 
				{
					node = stack.Pop();
					Console.WriteLine($"Удаляем из стэка посещенное поддерево {node.Value}");
				}
				
			}
			Console.WriteLine("Значение не найдено");
			return null;
		}
	}
}
