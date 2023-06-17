using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
	internal class Node
	{
		string data;
		Node next;

		public Node(string Data)
		{
			data = Data;
			next = null;
		}
		public string Data
		{
			get { return data; }
			set { data = value; }
		}
		public Node Next
		{
			get { return next; }
			set { next = value; }
		}
	}
}
