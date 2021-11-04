using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
	public class TwoLinkedList<T> : ILinkedList
		where T: Node
	{
		public int Count { get; set; }
		public Node Head { get; set; }
		public Node Tail { get; set; }

		public void AddNode(int value)
		{
			Node node = new(value);
			if (Head == null)
			{
				Head = node;
				Tail = node;
			}
			else 
			{
				AddNodeNext(Head.NextNode,value);
			}
			Count++;
		}

		private Node AddNodeNext(Node node, int value)
		{
			if (node == null)
			{
				node = new(value);
				Tail.NextNode = node;
				node.PrevNode = Tail;
				Tail = node;
				return node;
			}
			else
			{
				AddNodeNext(node.NextNode, value);

			}
			return node;
		}
		public void AddNodeAfter(Node node, int value)
		{
			WatchingNode(Head,node,value);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="listNodes">Предпологаемый список нод</param>
		/// <param name="addNode">нода которую хотим добавить</param>
		/// <param name="value">После какого значения добавиться нода</param>
		/// <returns></returns>
		private Node WatchingNode(Node listNodes,Node addNode,int value) 
		{
			if (listNodes.Value == value)
			{
				addNode.NextNode = listNodes.NextNode;
				listNodes.NextNode.PrevNode = addNode;
				listNodes.NextNode = addNode;
				addNode.PrevNode = listNodes;
				return listNodes;
			}
			else 
			{
				WatchingNode(listNodes.NextNode, addNode, value);
			}
			return listNodes;
		}

		public Node FindNode(int searchValue)
		{
			return FindNode(Head,searchValue);
		}
		private Node FindNode(Node node,int value) 
		{
			if (node.Value == value)
			{
				Console.WriteLine($"Node {node.Value} was found");
			}
			else if (node.NextNode == null)
			{
				Console.WriteLine($"Node {value} not was found");
			}
			else 
			{
				FindNode(node.NextNode, value);
			}
			return node;
		}

		public int GetCount()
		{
			return Count;
		}

		public void RemoveNode(int index)
		{
			throw new NotImplementedException();
		}

		public void RemoveNode(Node node)
		{
			
		}




		

	}

}
