using System;

namespace Exercise2
{
    class Exercise2
    {
        static void Main(string[] args)
        {
          
            
        Console.WriteLine("Please enter username: ");
        string username = Console.ReadLine();
        int user = int.Parse(username);

        Console.WriteLine("Now please enter password: ");
        string password = Console.ReadLine();
        int pass = int.Parse(password);
        
        Console.WriteLine(username);
        Console.WriteLine(password);

        if (user == 102317760)
            {
                if (pass == 1234)
                { 
                    Console.WriteLine("Login Successful");
                }
                else
                {   
                    Console.WriteLine("Login Unsuccessful");
                }
            }
        else
        {   
            Console.WriteLine("Login Unsuccessful");
        }

        }
    }
}