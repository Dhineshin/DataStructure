using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class InsertionSortDhinesh : ISort
    {
        public void Run()
        {
            // declare an array of integers that are not sorted
            //int[] nums = { 5, 10, 3, 2, 4 };
            int[] nums = { 7, 5, 4, 10, 3 };
            //int[] nums = { 100, 7, 5, 63, 4, 8, 83, 10, 17, 54, 32, 98, 3, 2, 1 };
            int min = 0;
            int max = 100;
            Random random = new Random();
            //int[] nums = Enumerable.Repeat(0, 5).Select(x => random.Next(min, max)).ToArray();

            Console.WriteLine();
            Console.Write("Before: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }


            bool swapped;
            do
            {
                for (int i = 0; i < nums.Length-1; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int temp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                    }

                    for (int j = i; j > 0; j--)
                    {
                        if (nums[j] < nums[j - 1])
                        {
                            int temp = nums[j - 1];
                            nums[j - 1] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }

                swapped = false;
            } while (swapped == true);


            Console.WriteLine();
            Console.Write("After: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }
            //Console.ReadLine();

        }
    }
}
