using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q17
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

		public int GetIndex(int data)
		{
			Node current = head;
			int index = 0;

			while (current != null)
			{
				if (current.Data == data)
				{
					return index;
				}

				current = current.Next;
				index++;
			}

			return -1; // Element not found
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
