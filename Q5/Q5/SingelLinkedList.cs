using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q5
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

            if(head == null)
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

        public void InsertAtFirstOfLinkedList(int data)
        {
			Node newNode = new Node(data);
			newNode.Next = head;
			head = newNode;
		}

        public void DisplayList()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
        }
    }
}
