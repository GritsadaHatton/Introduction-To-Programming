using System;
using System.Collections.Generic;

namespace Lists_Submittable
{
    class Lists2
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);

            for(int i = 0; i < nums.Count; i++)
            Console.WriteLine(nums[i]);
            
            for (int i = 1; i < 10; i++)
            {
            //I spent 4 hours and could not get this to "work" exactly as the task asks. Please help.
            Console.WriteLine("Please repeatedly enter the same number from 1-10: "); 
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= 10)
            Console.WriteLine("The number " + input + " has been entered " + i + " times");
            else
            Console.WriteLine("Wrong");
            }
        }
    }
}
