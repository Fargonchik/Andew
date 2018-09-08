using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class MyOwnType
    {
        int[] Array;
        public int Length;
        public MyOwnType(int size)
        {
            Array = new int[size];
            Length = size;
        }
        public int this[int Index]
        {
            get
            {
                return Array[Index];
            }
        }
        public int this[double index]
        {
            get
            {
                return Array[(int)Math.Round(index)];
            }
        }
    }
    class Program
    {
        public static void MyStack()
        {
            
        }

        static void Main(string[] args)
        {
            int StackSize = 16;
            MyOwnType Array = new MyOwnType(StackSize);

        }
    }
}
