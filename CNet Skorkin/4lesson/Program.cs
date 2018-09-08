using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    /// <summary>
    /// фиг его что это 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var foo = Sum(4);
            Console.WriteLine(foo);
            Console.ReadKey(); 
        }

        public static int Sum (int n)
        {
            if (n == 1) return 1;
            return n + Sum(n - 1);
        }
    }
}
