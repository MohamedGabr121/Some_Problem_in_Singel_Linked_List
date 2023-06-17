namespace Q11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//  11. Write a  c# program that removes the node from the singly linked list at the specified index. 

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
			Console.Write("Enter The Value  Delete of Linked List = ");
			int deleteValue = int.Parse(Console.ReadLine());
			singelLinkedList.DeleteValueInLinkedList(deleteValue);
			singelLinkedList.DisplayList();
		}
	}
}