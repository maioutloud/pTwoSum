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

            Console.WriteLine(TwoSum(array, 9));
            Console.WriteLine(TwoSum(array2, 17));
            Console.ReadKey();
        }

        static int[] TwoSum(int[] arr, int target)
        {
            for(int i = 0; i < arr.Length;i++)
            {
                for(int j = i + 1; j < arr.Length-1;j++)
                {
                    if (arr[i] + arr[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] {-1,-1};
        }

        static int[] DTwoSum(int[] arr, int target)
        {
            
            return new int[] {-1, -1};
        }
    }
}
