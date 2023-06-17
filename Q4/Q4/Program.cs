namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//  4. Write a  c# program to insert a node at any position in a Singly Linked List.

			SingelLinkedList singelLinkedList = new SingelLinkedList();
			Console.Write("Enter The Number Of The Noed Linked List = ");
			int numberOfNoed = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfNoed; i++)
			{
				Console.Write($"Enter The Noed Of Linked List Number {i} = ");
				int enterNumberOfList = int.Parse(Console.ReadLine());
				singelLinkedList.AddNode(enterNumberOfList);
			}
			singelLinkedList.InsertAtAnyPositionInLinkedList(20, 2);
			Console.Write("The Linked List Equal To : ");
			singelLinkedList.DisplayNode();
			Console.WriteLine();
		}
	}
}