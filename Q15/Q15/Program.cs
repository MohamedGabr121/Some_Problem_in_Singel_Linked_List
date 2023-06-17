using System.Collections.Generic;

namespace Q15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//  15. Write a  c# program to convert a Singly Linked list into an array.

			SingelLinkedList singelLinkedList = new SingelLinkedList();
			Console.Write("Enter The Number Of The Noed Linked List = ");
			int numberOfNoed = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfNoed; i++)
			{
				Console.Write($"Enter The Noed Of Linked List Number {i} = ");
				int enterNumberOfList = int.Parse(Console.ReadLine());
				singelLinkedList.AddNode(enterNumberOfList);
			}
			//singelLinkedList.DisplayList();
			Console.WriteLine();
			int[] array = singelLinkedList.convertLinkedListToArray();
			foreach (int i in array)
			{
				Console.WriteLine(i);
			}

		

		}
	}
}