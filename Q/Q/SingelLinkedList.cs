using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q
{
	public class SingelLinkedList
	{
		Noed head;
		Noed tail;
		public SingelLinkedList()
		{
			head = tail = null;
		}
		public void AddNoed(int Data)
		{
			Noed newNoed = new Noed(Data);
			if (head == null)
			{
				head = newNoed;
			}
			else
			{
				Noed current = head;

				while (current.Next != null)
				{
					current = current.Next;

				}
				current.Next = newNoed;
			}
		}

		public void DisplayList()
		{
			Noed current = head;

			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Next;
			}
			if (head == null)
			{
				Console.WriteLine("The Linked List Is Empty");
			}
		}

	}
}

