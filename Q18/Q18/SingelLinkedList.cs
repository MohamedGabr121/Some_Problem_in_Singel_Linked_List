using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18
{
	internal class SingelLinkedList
	{
		Node head;
		public SingelLinkedList()
		{
			head = null;
		}

		public void AddNode(int data)
		{
			Node newNoed = new Node(data);

			if (head == null)
			{
				head = newNoed;
			}
			else
			{
				Node current = head;
				while (current.Next != null)
				{
					current = current.Next;
				}
				current.Next = newNoed;
			}
		}

		public bool Contains(int element)
		{
			Node current = head;

			while (current != null)
			{
				if (current.Data == element)
				{
					return true;
				}

				current = current.Next;
			}

			return false;
		}


		public void DisplayList()
		{
			Node current = head;
			if (head == null)
			{
				Console.WriteLine("The Linked List Is Empty : ");

			}
			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Next;
			}

		}
	}
}
