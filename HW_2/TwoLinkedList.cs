using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
	public class TwoLinkedList : ILinkedList
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
			Node searchValue = FindNode(value);
			node.NextNode = searchValue.NextNode;
			searchValue.NextNode.PrevNode = node;
			searchValue.NextNode = node;
			node.PrevNode = searchValue;
			Count++;
		}		
		public Node FindNode(int searchValue)
		{
			Node searchNodeValue = Head;
			while (searchNodeValue.Value != searchValue)
			{
				if (searchNodeValue.NextNode == null) 
				{
					Console.WriteLine($"Node {searchValue} was not found");
					return searchNodeValue;
				}
				searchNodeValue = searchNodeValue.NextNode;
			}
			return searchNodeValue;
		}
		public int GetCount()
		{
			return Count;
		}

		public void RemoveNode(int index)
		{
			int indexNode = 0;
			Node searchNodeValue = Head;
			while (indexNode != index)
			{
				searchNodeValue = searchNodeValue.NextNode;
				indexNode++;
				if (searchNodeValue == null) 
				{
					throw new IndexOutOfRangeException("Индекс вышел за пределы границы");
				}
			}
			RemoveNode(searchNodeValue);
			
		}

		public void RemoveNode(Node node)
		{
			if (node == Head) 
			{
				Head = node.NextNode;
			}
			else
			{
				node.PrevNode.NextNode = node.NextNode;
				if (node.NextNode != null) 
				{
					node.NextNode.PrevNode = node.PrevNode;
				}
			}
			Count--;
		}




		

	}

}
