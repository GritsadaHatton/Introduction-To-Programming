using System;

namespace Lists_Submittable
{
    class Lists_Submittable
    {
        static void Main(string[] args)
        {

            int size = 5;

            int[] numbers = new int [size];


            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;


            int index = 0;


            while(index < numbers.Length)
            {
                System.Console.WriteLine(numbers[index]);

                index++;
            }


            // int input = 0;
            // Console.WriteLine("Enter a number: ");
            // Console.ReadLine();

            // if (input <= numbers[index])
            // {
            //     Console.WriteLine("This number already exists");
            // }

            // else if (input > numbers[index])
            // {
            //     Console.WriteLine("Yay");
            // }

        }
    }
}
