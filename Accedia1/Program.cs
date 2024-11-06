namespace Binary_Sort
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 1, 27, 16, 4 };

			Array.Sort(arr, (a,b) =>
			{
				int lastFourBitsA = a & 0b1111;
				int lastFourBitsB = b & 0b1111;

				return lastFourBitsA.CompareTo(lastFourBitsB);
			});

            Console.WriteLine(String.Join(", ", arr));
        }
	}
}
