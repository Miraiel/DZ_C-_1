using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double meaning = Convert.ToInt32(Console.ReadLine());
            int percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(meaning / 100 * percent);
        }
    }
}
