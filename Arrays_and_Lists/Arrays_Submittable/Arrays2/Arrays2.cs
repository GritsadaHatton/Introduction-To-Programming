using System;

namespace Arrays_Submittable
{
    class Arrays2
    {
        static void Main(string[] args)
        {
            
            int[] values = new int[10] {34, 5, 67, 1, 99, 34, 44, 78, 32, 0};

            int total = 0;

            for (int i = 0; i < values.Length; i++)
                {
                    total += values[i];
                }

            System.Console.WriteLine("Total is: " + total);
        }
    }
}
