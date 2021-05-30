using System;

namespace Arrays_and_Lists
{
    class Arrays_and_Lists
    {
        static void Main(string[] args)
        {

            //declaring array
            int size = 5;
            int[] numbers = new int[size];

            numbers[2] = 38;
            numbers[0] = 1;
            numbers[1] = 2323;
            numbers[3] = 86;
            numbers[4] = 103;

            int index = 0;
        

            while (index < numbers.Length)
            {
                System.Console.WriteLine(numbers[index]);

                index++;
            }

            int[] scores = new int[10];
            int total = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());

                scores[i] = input;
                //total = total + input;
                total += input;
            }

            System.Console.WriteLine("=================================================");

            for (int i = 0; i < scores.Length; i++)
            {
                System.Console.WriteLine(scores[i]);
            }

            System.Console.WriteLine("Total is: " + total);


        }
    }
}
