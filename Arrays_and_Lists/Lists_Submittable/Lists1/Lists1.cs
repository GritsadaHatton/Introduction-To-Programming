using System;
using System.Collections.Generic;

namespace Lists_Submittable
{
    class List1
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
            
            Console.WriteLine("Please enter a number from 1-10: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= 5)
            Console.WriteLine("Sorry, your princess is in another castle. Please try again.");
            else
            Console.WriteLine("Great Job, you rescued the princess!");

            

        }
    }
}
