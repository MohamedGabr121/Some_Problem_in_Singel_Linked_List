﻿namespace Q10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 10. Write a  c# program to empty a singly linked list by pointing the head towards null.

			SingelLinkedList singelLinkedList = new SingelLinkedList();
			Console.Write("Enter The Number Of The Noed Linked List = ");
			int numberOfNoed = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfNoed; i++)
			{
				Console.Write($"Enter The Noed Of Linked List Number {i} = ");
				int enterNumberOfList = int.Parse(Console.ReadLine());
				singelLinkedList.AddNode(enterNumberOfList);
			}
			singelLinkedList.DisplayList();
			Console.WriteLine();

			singelLinkedList.EmptyLinkedList();
			singelLinkedList.DisplayList();

		}
	}
}