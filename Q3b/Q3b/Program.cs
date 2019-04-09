using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3b
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 6; //This is the answer
            bool win = false;

            Console.WriteLine("Try solve the follwing algebraic expression 2(x-3) + x = 12");

            do
            {
                Console.WriteLine("What do you think the value of x is:");
                int guess = int.Parse(Console.ReadLine());

                if (guess != x)
                {
                    Console.WriteLine("Incorrect. Please try again!");

                }
                else
                {

                    // 2(x-3)+x=12
                    // 2(x-3+3)+x=12
                    // 2(x) = 12
                    // 12/2 = 6
                    // x = 6

                    Console.WriteLine("That is corect! Press any key to exit.");
                    win = true;
                    
                }
            } while (win == false);

            
            Console.ReadLine();
        }
    }
}
