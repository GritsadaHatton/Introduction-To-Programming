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

        Console.Write("Please enter your gender: ");
        string gender = Console.ReadLine();

        Console.Write("Please enter a random number between 1-10: ");
        string Number = Console.ReadLine();
        int Num = int.Parse(Number);

        Console.Write("Please enter another random number between 1-10: ");
        string Number2 = Console.ReadLine();
        int Num2 = int.Parse(Number2);


        Console.WriteLine(Num + Num2);

        if (Num + Num2 == 10)
            {
                Console.Write("Sum of numbers is equal to 10, ");
            }
            else if (Num + Num2 > 10)
            {
            Console.Write("Sum of numbers is greater than 10, ");
            }
            else if (Num + Num2 < 10)
            {
            Console.Write("Sum of numbers is less than 10, ");
            }


        if (ageNum > 17)
            {
                Console.WriteLine(gender + " is an adult");
            }
            else
            {
                Console.WriteLine(gender + " is not an adult");
            }

        

        }
    }
}
