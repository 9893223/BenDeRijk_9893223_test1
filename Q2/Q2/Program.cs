using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {


            float total = 0;

            Console.WriteLine("This program will give the sum total of 5 prices input by you!");

            for (float i = 1; i <= 5; i++) 
            {
                Console.Write($"Please enter price {i}:$");

                total += float.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nThe total price is:${total}");

            Console.ReadLine();
        }
    }
}
