namespace Q8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//  8. Write a  c# program to find the first index that matches a given element. Return -1 for no matching.

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
			Console.Write("Please Enter The Number To Find The Index = ");
			int index = int.Parse(Console.ReadLine());
			int indexOfLinkedList = singelLinkedList.GetFirstIndex(index);
			Console.WriteLine(indexOfLinkedList);
		}
	}
}