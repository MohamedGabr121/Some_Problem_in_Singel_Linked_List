namespace Q
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 1. Write a  c# program to create and display a Singly Linked List.
			SingelLinkedList singelLinkedList = new SingelLinkedList();
			Console.Write("Enter The Number Of The Noed Linked List = ");
			int numberOfNoed = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfNoed; i++)
			{
				Console.Write($"Enter The Noed Of Linked List Number {i} = ");
				int enterNumberOfList = int.Parse(Console.ReadLine());
				singelLinkedList.AddNoed(enterNumberOfList);
			}
			singelLinkedList.DisplayList();

		}
	}
}