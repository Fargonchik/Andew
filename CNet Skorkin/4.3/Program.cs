using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._3
{
    class Program : svaston
    {
        static void Main(string[] args)
        {
            /* var obj = new Control[3][];
             Console.WriteLine(obj.GetLowerBound());
             obj[0] = new[] { new Control(), new Control(), new Control() };
             obj[1] = new[] { new Control() };
             obj[2] = new Control[] { };

             for (int i = 0; i < obj.Length; i++)
             {
                 Console.WriteLine(obj[i].GetUpperBound(0));
             }

             var foo = Array.CreateInstance(typeof(Control), new int[] { 5 }, new int[] { 2 });
             Console.WriteLine(foo.GetLowerBound(0));
             Console.WriteLine(foo.GetLowerBound(0));
             foo.SetValue(2, foo.GetLowerBound(0));

             for (int i = 0; i < foo.Length; i++)
             {
                 Console.WriteLine(foo.GetValue(foo.GetLowerBound(0) + i));
             }

             Console.ReadKey();
         }
         public class Control
         {

         }
         */

            unsafe
            {
                Console.BackgroundColor = ConsoleColor.Red;
                int size = 2;
                char* pc = stackalloc Char[size];
                for (int i = 0; i < size; i++)
                {
                    pc[size - i - 1] = 'S';
                }

                Console.WriteLine(new String (pc, 0, size));
                Console.WriteLine();
                Console.ReadKey();
            }
            Console.Beep();
            
        }
        
    }
}