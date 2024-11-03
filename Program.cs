using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pTwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Classic Two Sum Project
            // The problem is, given a target
            // Find two numbers in an array that
            // add up to the target

            int[] array = { 2, 4, 5, 6, 7 };  // 9
            int[] array2 = { 5, 9, 1, 8, 3 }; // 17

            // -With Array need multiple elements to output
            //  you need to create a collection to store the 
            //  results, since Console.Write(TwoSum(array, 9)) won't work
            int[] result1 = DTwoSum(array, 9);
            int[] result2 = DTwoSum(array2, 17);
            
            // -This print method works for using a foreach loop-
            Console.Write("Indices for array1: ");
            foreach (int index in result1)
            {
                Console.Write($"{index} ");
            }
            Console.WriteLine();

            Console.Write("Indices for array2: ");
            foreach (int index in result2)
            {
                Console.Write($"{index} ");
            }
            Console.WriteLine();

            // -This method uses one line to output the results-
            //  The result is already stored in result1, result2
            // Console.WriteLine($"[{result1[0]}, {result1[1]}]");
            // Console.WriteLine($"[{result2[0]}, {result2[1]}]");

            // This example will not work and output a system32[]
            // Console.WriteLine(TwoSum(array, 9));
            // Console.WriteLine(TwoSum(array2, 17));
            
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] arr, int target)
        {
            for(int i = 0; i < arr.Length;i++)
            {
                for(int j = i + 1; j < arr.Length;j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] {-1,-1};
        }

        public static int[] DTwoSum(int[] arr, int target)
        {
            // collection to store what is seen
            // if it's not seen, add it to the dictionary
            // must have a logic to determine the numbers that add up to target
            
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                // determine complement
                int complement = target - arr[i];
                
                // if complement is already in the dictionary, then return the result
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                // if not, then add the element
                dict[arr[i]] = i;
            }

            // if no paring is found, return a false outcome
            return new int[] {-1, -1};
        }
    }
}
