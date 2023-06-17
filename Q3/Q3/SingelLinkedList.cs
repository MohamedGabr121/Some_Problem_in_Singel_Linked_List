using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
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

            if(head == null)
            {
                head = newNoed;
            }
            else
            {
                Node current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNoed;
            }
        }

		public int countOFLinkedList()
		{
			int count = 0;
			Node current = head;
			while (current != null)
			{
				count++;
				current = current.Next;
			}
			return count;
		}

		public void DisplayList()
        {
            Node current = head;

            while(current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            if(head == null)
            {
                Console.WriteLine("The Linked List IS Empty : ");
            }
        }

        
	}
}
