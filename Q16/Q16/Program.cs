namespace Q16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//  16. Write a  c# program to convert a Singly Linked list into a string.

			SingelLinkedList singelLinkedList = new SingelLinkedList();
			Console.Write("Enter The Number Of The Noed Linked List = ");
			int numberOfNoed = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfNoed; i++)
			{
				Console.Write($"Enter The Noed Of Linked List string {i} = ");
				string enterNumberOfList = Console.ReadLine();
				singelLinkedList.AddNode(enterNumberOfList);
			}
			//singelLinkedList.DisplayList();
			Console.WriteLine();
			string[] array = singelLinkedList.ConvertLinkedListToArrayofString();
			foreach (string i in array)
			{
				Console.WriteLine(i);
			}
		}
	}
}