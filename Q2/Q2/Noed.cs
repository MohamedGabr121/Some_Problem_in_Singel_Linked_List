using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Noed
	{

		int data;
		Noed next;

		public Noed(int Data)
		{
			data = Data;
			next = null;
		}
		public int Data
		{
			get { return data; }
			set { data = value; }
		}
		public Noed Next
		{
			get { return next; }
			set { next = value; }
		}

	}
}
