namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SingelLinkedList singelLinkedList = new SingelLinkedList();
			Console.Write("Enter The Number Of The Noed Linked List = ");
			int numberOfNoed = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numberOfNoed; i++)
			{
				Console.Write($"Enter The Noed Of Linked List Number {i} = ");
				int enterNumberOfList = int.Parse(Console.ReadLine());
				singelLinkedList.AddNodeLastLinkedList(enterNumberOfList);
			}
			Console.Write("The Linked List Equal To : ");
			singelLinkedList.DisplayNode();
			
		}
	}
}