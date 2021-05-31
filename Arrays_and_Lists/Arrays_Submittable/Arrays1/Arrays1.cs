using System;

namespace Arrays_Submittable
{
    class Arrays1
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



            

                

        }
    }
}