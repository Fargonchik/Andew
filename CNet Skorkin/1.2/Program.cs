using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    ///Polymorphism
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MyClass<string>();
            var str = a.Create();
            
        }
    }
    public class MyClass<T> where T:class
    {
        public T Create()
        {
            return default (T);
        }
    }
}
