using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass d = new MyDerivedClass();
            MyBaseClass b = d;
            d.DoSomething();
            Console.ReadKey();
        }
    }

    class MyBaseClass
    {
        public void DoSomething()
        {
            Console.WriteLine("Base class");
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        new public void DoSomething()
        {
            Console.WriteLine("derived class");
        }
    }
}
