namespace Q9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 9. Write a  c# program to check whether a single linked list is empty or not. Return true otherwise false.

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

			bool res = singelLinkedList.CheckLinkedList();
			Console.WriteLine(res);

		}
	}
}