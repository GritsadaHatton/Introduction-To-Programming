using System;

namespace SelectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.Write("Please enter your age: ");
        string age = Console.ReadLine();

        int ageNum = int.Parse(age);

        if (ageNum > 17)
            {
                Console.WriteLine("Legally Adult Age");
            }
            else
            {
                Console.WriteLine("Leagally Not Adult Age");
            }



        }
    }
}
