using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceDemo
{

    class parent { } // if you put sealed class on parent, Child class cannot inherit it
    sealed class child : parent { } // if you put sealed class on child, below example class cannot inherit it

    static class example
    {
        public static void ex()
        {

        }
    }


    abstract class abstractexample
    {
        int a = 5;
        int b = 10;
        public void printa()
        {
            Console.WriteLine("value of a : " + a);
        }

        public virtual void printb()
        {
            Console.WriteLine("value of b: " +b);
        }
    }


    class sample : abstractexample
    {
        int b = 20;

        public override void printb()
        {
            Console.WriteLine("value of abstractexample b: " + base.b);

            Console.WriteLine("value of sample b: " + b);
        }
    }

    class sample2 : abstractexample
    {

    }
    class AbstractClassExample
    {

        public static void Main ()
        {
            //stattic class example
            //example.ex();

           
            //Abstract class example
            sample s = new sample();
            s.printa();
            s.printb();

            sample2 s2 = new sample2();
            s2.printa();
            s2.printb();
        }
    }
}
