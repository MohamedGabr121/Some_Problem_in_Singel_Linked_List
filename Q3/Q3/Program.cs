namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//  3. Write a  c# program to create a singly linked list of n nodes and count the number of nodes.


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
			int countOfLinkedList = singelLinkedList.countOFLinkedList();
			Console.Write("The Size Of Linked ListIs Equal to  : " + countOfLinkedList);

			

		}
	}
}