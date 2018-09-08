using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Control[3][];
            obj[0] = new[] { new Control() , new Control() , new Control() };
            obj[1] = new[] { new Control() };
            obj[2] = new Control[] { };

            for (int i = 0; i < obj.Length; i++)
            {
                Console.WriteLine(obj[i].GetUpperBound(0));
            }

            Console.ReadKey();
        }
        public class Control
        {

        }
    }
}
