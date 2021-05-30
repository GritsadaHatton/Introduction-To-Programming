using System;

namespace Arrays_Submittable
{
    class Arrays_Submittable
    {
        static void Main(string[] args)
        {
            int size = 5;
            string[] names = new string[size];


            names[0] = "Ada";
            names[1] = "Lakeith";
            names[2] = "Jurnee";
            names[3] = "Wunmi";
            names[4] = "Mahershala";


            int index = 0;
          
            while (index < names.Length)
            {
                System.Console.WriteLine("Hello " + names[index]);

                index++;
            }



            

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