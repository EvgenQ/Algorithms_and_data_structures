using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
	class TreeNode
	{
		public int Value { get; set; }
		public TreeNode Left { get; set; }
		public TreeNode Right { get; set; }
		public bool Visited { get; set; }

		public TreeNode()
		{

		}
		public TreeNode(int value)
		{
			Value = value;
		}
	}
}
