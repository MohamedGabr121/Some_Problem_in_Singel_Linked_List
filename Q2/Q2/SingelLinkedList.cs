using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q2
{
	internal class SingelLinkedList
	{
		Noed head;

        public SingelLinkedList()
        {
            head = null;
        }

        public void AddNoed(int Data)
        {
            Noed newNoed = new Noed(Data);

            if(head == null)
            {
                head = newNoed;
            }
            else
            {
                Noed current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNoed;
            }
        }

        public void DisplayList()
        {
            Noed current = head;
            if(head == null)
            {
                Console.WriteLine("The Linked List Is Empty : ");

            }
           while(current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

        }

        public void ReverseList()
        {
			Noed previous = null;
			Noed current = head;
			Noed next = null;

			while (current != null)
			{   
                
				next = current.Next;
				current.Next = previous;
				previous = current;
				current = next;
			}

			head = previous;
		}

	}
}
