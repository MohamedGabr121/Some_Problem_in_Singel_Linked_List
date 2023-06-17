using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class SingelLinkedList
	{
		Node head;
		Node tail;
        public SingelLinkedList()
        {
            head = tail = null;
        }

		public void AddNodeLastLinkedList(int data)
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
