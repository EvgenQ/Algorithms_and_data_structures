using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4
{
	public class TreeNode
	{
		public int Value { get; set; }
		public TreeNode Left { get; set; }
		public TreeNode Right { get; set; }
		public TreeNode()
		{

		}
		public TreeNode(int value)
		{
			Value = value;
		}
	}
}
