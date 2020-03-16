using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class SelectionSort : ISort
    {
        public void Run()
        {
            int[] nums = { 10,9,8,2,3,4,5,6,7,1 };

            Console.Write($"Before Ordering:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0},", nums[i]);
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {                
                for (int j = i; j >= nums.GetLowerBound(0); j--)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }
                    else
                    {
                        break;
                    }
                }

            }

            Console.WriteLine();
            Console.Write($"After Ordering:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0},", nums[i]);
            }
        }
    }
}
