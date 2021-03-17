using System;

namespace Variables
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            //This is where I have declared the datatypes;
            string Word1;
            string Word2;
            string Word3;
            string Word4;
            string Word5;
            int Num1;
            int Num2;
            int Num3;

            //This is how the user can input data and tells the software what to do after the user input;
            Console.WriteLine("Please Enter First Name.");
            Word1 = Console.ReadLine();
            
            Console.WriteLine("Please Enter Surname.");
            Word2 = Console.ReadLine();
            
            Console.WriteLine("Please Enter Student ID.");
            Word3 = Console.ReadLine();
           
            Console.WriteLine("Please Enter Year of Birth.");
            Word4 = Console.ReadLine();
           
            Console.WriteLine("Please Enter Current Year.");
            Word5 = Console.ReadLine();

            //These lines convert Word[3, 4, 5] into ints and assigns to Num[1, 2, 3] respectively;
            Num1 = int.Parse(Word3);
            Num2 = int.Parse(Word4);
            Num3 = int.Parse(Word5);

            //Output;
            Console.WriteLine(Word1 + Word2);
            Console.WriteLine(Num3 - Num2);
            Console.WriteLine(Num1);
        }
    }
}
