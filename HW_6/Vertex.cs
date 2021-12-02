using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
	public class Vertex
	{
		public string Name { get; set; }
		public List<Edge> Edges { get; set; }
		public Vertex()
		{

		}
		public Vertex(string nameCity)
		{
			Name = nameCity;
			Edges = new List<Edge>();
		}
		
		public override string ToString()
		{
			return Name.ToString();
		}
	}
}
