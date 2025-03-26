namespace Practice
{
	public class Program
	{
		static void Main(string[] args)
		{
			// Sort the array using 4-bit unsigned binary values of array numbers
			int[] arr = new int[] { 1, 27, 16, 4 };

			Array.Sort(arr, (a,b) =>
			{
				int lastFourBitsA = a & 0b1111;
				int lastFourBitsB = b & 0b1111;

				return lastFourBitsA.CompareTo(lastFourBitsB);
			});

            Console.WriteLine(String.Join(", ", arr));

			// Practice If-Else
			// looping through different scenarios about Fizz and Buzz
			for(int i = 1;i<=n; i++)
			{
                if(i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
	}
}
