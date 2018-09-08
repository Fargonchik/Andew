using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1
{
    /// <summary>
    /// Модификаторы доступа практика
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MyClass();
                a.Method();
        }
    }

    public class MyClass
    {
        public int Foo { get; set; }

        private void Bar()
        {

        }
        protected int baz = 1;
        internal void Method ()
        {
            Console.WriteLine("Method");
        }
    }
}
