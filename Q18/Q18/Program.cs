namespace Q18
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 18. Write a  c# program to check if an element is present in the Singly Linked list.

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

			int enterElement = int.Parse(Console.ReadLine());
			bool enterOfElementLinkedList = singelLinkedList.Contains(enterElement);
			Console.WriteLine(enterOfElementLinkedList);
		}
	}
}