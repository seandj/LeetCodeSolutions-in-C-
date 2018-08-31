﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 0, 3, 4 };
            int target = 0;

            var result = TwoSum(nums, target);

            Console.WriteLine("{0} and {1}", result[0], result[1]);

            Console.ReadKey();
        }

        public static int[] TwoSum(int[] numbers, int target)
        {

            //由于数组是有序的，采取两端逼近的办法解决

            int min = 0;

            int max = numbers.Length - 1;

            while (true)
            {
                if (numbers[min] + numbers[max] == target)
                {
                    return new int[] { min + 1, max + 1 };
                }
                if (numbers[min] + numbers[max] > target)
                    max--;
                else
                    min++;
            }
        }
    }


}
