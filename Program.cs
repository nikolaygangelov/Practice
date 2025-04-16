﻿namespace Practice
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

			// Task 3
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

			// Task 4
			// Moving through directories with minimum steps – What are the number of minimum steps to go back to first place 
			// if possible moves are “./” (no move), “../” (goes 1 level up), “x" or other letter (goes 1 level down) 
			// and actual moves are [“x/”, “y/”, “../”, “./”, “z/”]?
			
		        string[] moves = {"x", "y", "../", "./", "z"};
		        int minSteps = 0;
			
		        for (int i = 0; i < moves.Length; i++)
		        {
		            if(moves[i] == "../")
		            {
		                Console.WriteLine("up");
		                Console.WriteLine(--minSteps);
		            }
		            else if(moves[i] == "./")
		            {
		                Console.WriteLine("no move");
		            }
		            else if((int)moves[i][0] > 96 && (int)moves[i][0] < 123)
		            {
		                Console.WriteLine("down");
		                Console.WriteLine(++minSteps);
		            }
		        }
        	}
	}
}
