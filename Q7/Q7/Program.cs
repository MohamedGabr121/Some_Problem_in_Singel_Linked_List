namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//  7. Write a  c# program to get a node in an existing singly linked list.

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
			Console.Write("Please Enter The Number Of Search the Node of Linked List =  ");
			int getNode = int.Parse(Console.ReadLine());
			Node foundNode = singelLinkedList.GetNode(getNode);
			if(foundNode != null )
			{
				Console.WriteLine($"Node with value {getNode} found.");

			}
			else
			{
				Console.WriteLine($"Node with value {getNode} not found.");
			}
			Console.WriteLine();
		}
	}
}