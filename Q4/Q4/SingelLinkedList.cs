using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
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
			Node newNode = new Node(data);

			if (head == null)
			{
				head = newNode;
			}
			else
			{
				Node current = head;
				while (current.Next != null)
				{
					current = current.Next;
				}
				current.Next = newNode;
			}
		}

		public void InsertAtAnyPositionInLinkedList(int data, int position)
		{
			Node newNode = new Node(data);
			if (position == 1)
			{
				newNode.Next = head;
				head = newNode;
			}
			else
			{
				Node current = head;
				for (int i = 1; i < position - 1; i++)
				{
					if (current != null)
					{
						current = current.Next;
					}
				}
				if (current != null)
				{
					newNode.Next = current.Next;
					current.Next = newNode;
				}
				
			}


		}

		public void DisplayNode()
		{
			Node current = head;
			while (current != null)
			{
				Console.Write(current.Data + " ");
				current = current.Next;
			}
			if (head == null)
			{
				Console.WriteLine("The Linked List Is Empty : ");
			}
		}
	}
}
