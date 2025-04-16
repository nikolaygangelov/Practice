namespace Practice
{
	public class Program
	{
		static void Main(string[] args)
		{
			//Task 1
			// Sort the array using 4-bit unsigned binary values of array numbers
			int[] arr = new int[] { 1, 27, 16, 4 };

			Array.Sort(arr, (a,b) =>
			{
				int lastFourBitsA = a & 0b1111;
				int lastFourBitsB = b & 0b1111;

				return lastFourBitsA.CompareTo(lastFourBitsB);
			});

            		Console.WriteLine(String.Join(", ", arr));

			//Task 2
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

			//Task 3
			// Define the distinct couples of elements in an array whose sum is 12. A distinct couples are (3,9), (9,3) but (6,6) counts one time.  
			int[] nums = { 3, 9, 3, 6, 6, 6, 0, 12 };
		        int targetSum = 12;
		
		        Dictionary<string, int> pairCounts = new Dictionary<string, int>();
		
		        for (int i = 0; i < nums.Length; i++)
		        {
		            for (int j = 0; j < nums.Length; j++)
		            {
		                if (i == j) continue; // skip same element
		
		                if (nums[i] + nums[j] == targetSum)//6+6=12
		                {
		                    string key = $"{nums[i]},{nums[j]}";
		
		                    if (pairCounts.ContainsKey(key))
		                        pairCounts[key]++;
		                    else
		                        pairCounts[key] = 1;
		                }
		            }
		        }
		
		        Console.WriteLine($"Number of distinct couples: {pairCounts.Count}");
		        foreach (var pair in pairCounts)
		        {
		            Console.WriteLine($"({pair.Key})");
		        }
        	}
	}
}
