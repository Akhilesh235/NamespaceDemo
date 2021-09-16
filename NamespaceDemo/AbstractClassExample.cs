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
    class AbstractClassExample
    {

        public static void Main ()
        {

        }
    }
}
