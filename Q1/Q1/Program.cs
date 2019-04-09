using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will give the result of base^exponent");

            Console.WriteLine("Please enter the value of the base number:");
            int baseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter thr value of the exponent:");
            int expo = int.Parse(Console.ReadLine());

            Console.WriteLine($"{baseNum}^{expo} = {Math.Pow(baseNum, expo)}");
                

            Console.ReadLine();
        }
    }
}
