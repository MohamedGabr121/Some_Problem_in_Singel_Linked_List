namespace Q5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//  5. Write a  c# program to insert a node at the beginning of a Singly Linked List.
			SingelLinkedList singelLinkedList = new SingelLinkedList();
			Console.Write("Enter The Number Of The Noed Linked List = ");
			int numberOfNoed = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfNoed; i++)
			{
				Console.Write($"Enter The Noed Of Linked List Number {i} = ");
				int enterNumberOfList = int.Parse(Console.ReadLine());
				singelLinkedList.AddNode(enterNumberOfList);
			}
			Console.Write("The Linked List Equal To : ");
			singelLinkedList.DisplayList();
			Console.WriteLine();
			Console.Write("Please The Insert a node at the beginning The Number Of Linked List = ");
			int insertatTheBeginning = int.Parse(Console.ReadLine());
			Console.Write("After The Insert The First Linked List : ");
			singelLinkedList.InsertAtFirstOfLinkedList(insertatTheBeginning);
			singelLinkedList.DisplayList();
		}
	}
}