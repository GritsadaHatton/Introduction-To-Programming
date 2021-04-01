using System;

namespace Nested
{
    class Nested
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name: ");
            string name = Console.ReadLine();

            int counter = 0;

            while (counter <10)
            {
                counter++;
                int counter2 = counter;

                while (counter2 < 5)
                {
                    Console.Write(name);
                    counter2++;
                }
                Console.WriteLine();
                
            }
            Console.WriteLine("Goodbye " + name);
        }
    }
}
