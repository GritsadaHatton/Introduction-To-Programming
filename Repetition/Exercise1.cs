using System;

namespace Repetition
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            
            System.Console.Write("How many times would you like to repeat?: ");
            string repeat = Console.ReadLine();
            int r = int.Parse(repeat);
            
            
            int counter = 0;
            

            while (counter < r)
            {
                System.Console.Write("Please enter a name: ");
                string input = Console.ReadLine();
            
                System.Console.WriteLine(input);

                //counter = counter + 1
                counter++;
            }

            System.Console.WriteLine("Goodbye");
        }
    }
}
