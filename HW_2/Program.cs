using System;
using System.Collections.Generic;

namespace HW_2
{
	class Program
	{
		static void Main(string[] args)
		{
			TwoLinkedList<Node> list = new TwoLinkedList<Node>();
			Node newNode = new(33);
			list.AddNode(10);
			list.AddNode(20);
			list.AddNode(30);
			list.AddNode(40);
			list.AddNode(50);
			
			list.AddNodeAfter(newNode, 20);

			list.FindNode(44);

			list.RemoveNode(


		}
	}
}
