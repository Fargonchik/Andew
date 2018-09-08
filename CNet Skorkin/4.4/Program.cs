using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 100;
            var random = new Random();
            
            

            int[] arr = new int[4];

            for (int i = 0; i < arr.Length -1; i++)
            {
                var e = random.Next(min, max);
                arr[i] = e;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int a = 0;
                        a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;

                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
