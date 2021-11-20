using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HW_4
{
	public class BinaryTree
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

		public TreeNode Find(int value)
		{
			TreeNode node = Root;
			while (node.Value != value)
			{
				if (node.Value > value)
				{
					node = node.Left;
				}
				else
				{
					node = node.Right;
				}
				if (node == null)
				{
					Console.WriteLine("not found");
				}
			}
			Console.WriteLine("Finded");
			return node;
		}
		public void Delete(int value)
		{
			if (Root.Value > value)
			{
				Root.Left = GoNext(Root.Left, value);
			}
			else 
			{
				Root.Right = GoNext(Root.Right, value);
			}
		}
		private TreeNode GoNext(TreeNode node, int value)
		{
			if (node == null) return node;
			if (node.Value == value)
			{
				if (node.Left != null)
				{
					GoNext(node.Left, value);
					node.Left = null;
					GoNext(node.Right, value);
					node = null;
				}
				else
				{
					if (node.Right == null)
					{
						node = null;
					}
					else
					{
						GoNext(node.Right, value);
						node.Right = null;
					}
				}
			}
			else if (node.Value > value)
			{
				GoNext(node.Left, value);
				node.Left = null;
			}
			else if (node.Value < value)
			{
				GoNext(node.Right, value);
				node.Right = null;
			}
			return node;
		}
		public void PrintTree() 
		{
			Print(Root, 10, 0);
		}
		private int Print(TreeNode node, int x, int y)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(node.Value);
			Thread.Sleep(125);

			var loc = y;

			if (node.Right != null)
			{
				Console.SetCursorPosition(x + 2, y);
				Console.Write("--");
				Thread.Sleep(125);
				y = Print(node.Right, x + 4, y);
			}

			if (node.Left != null)
			{
				while (loc <= y)
				{
					Console.SetCursorPosition(x, loc + 1);
					Console.Write(" |");
					Thread.Sleep(125);
					loc++;
				}
				y = Print(node.Left, x, y + 2);
			}

			return y;
		}

	}
}
