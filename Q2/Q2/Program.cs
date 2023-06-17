namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//  2. Write a  c# program to create a singly linked list of n nodes and display it in reverse order.

			SingelLinkedList singelLinkedList = new SingelLinkedList();
			Console.Write("Enter The Number Of The Noed Linked List = ");
			int numberOfNoed = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfNoed; i++)
			{
				Console.Write($"Enter The Noed Of Linked List Number {i} = ");
				int enterNumberOfList = int.Parse(Console.ReadLine());
				singelLinkedList.AddNoed(enterNumberOfList);
			}
			Console.Write("Before The Reverse Linked List : ");
			singelLinkedList.DisplayList();
			Console.WriteLine();
			singelLinkedList.ReverseList();
			Console.Write("After The Reverse Linked List : ");
			singelLinkedList.DisplayList();
		}
	}
}