using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
	public class Edge
	{
		public (Vertex To,int kilometers) ConnectedVertex { get; set; }
		public Edge((Vertex to, int kilometers) connectedVertex)
		{
			ConnectedVertex = (connectedVertex.to,connectedVertex.kilometers);
		}

		public Edge()
		{
		}
	}
}
