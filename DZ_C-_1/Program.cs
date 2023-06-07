using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_C__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number from 1 to 100: ");
            int nam = Convert.ToInt32(Console.ReadLine());
            if (nam % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            if (nam % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            if (nam % 3 == 0 || nam % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            if (nam % 3 != 0 | nam % 5 != 0)
            {
                Console.WriteLine($"{nam}");
            }
            if (nam < 1 | nam > 100)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
