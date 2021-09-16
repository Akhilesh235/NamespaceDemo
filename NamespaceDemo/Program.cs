using System;
//using NamespaceDemo.Parent
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceDemo                 // how to have oops in namespace
{
    struct structexaple
    {
        int a;
        int b;
        long c;
    }


    class Program          // default is internal
    {
        static void Main(string[] args)
        {
            ////NamespaceDemo.Parent ParentClass

            //// SizeOf Operator

            //int i = 5;
            //int[] arr = new int[10];
            ////structexaple ex = new structexaple();

            //Console.WriteLine( "length of arr : " + arr.Length);

            //Console.WriteLine("int : " + sizeof(int));
            //Console.WriteLine("long : " + sizeof(long));
            //Console.WriteLine("char : " + sizeof(char));
            //Console.WriteLine("double : " + sizeof(double));
            //Console.ReadLine();


            // as operator - reference type conversion

            //string str1 = "Session ";
            //object obj = "sessionobject";

            //var n = str1 as object;
            //var m = obj as string;
            //var p = obj as a;
            object conva = ainstance as object

                if (conva is b)
            {
                //b conva1 = conva as b;
                Console.WriteLine("Can be converted to b");
            }
            else
            {
                Console.WriteLine("Cannot be converted to b");
            }
                if (conva is args conva1)
            {
                conva.print();
                Console.WriteLine("can be converted to a");
            }

            //if (n!= null)
            //{
            //    Console.WriteLine("Successfully converted str1");
            //}

            //if (m != null)
            //{
            //    Console.WriteLine("Successfully converted obj");
            //}

            //else
            //{
            //    Console.WriteLine("conversion failed for obj");
            //}
            Console.Read();

        }
    }
}


namespace NamespaceDemo.Parent
{
    class ParentClass
    {
        void print()
        {
            Console.WriteLine(" in parent namespace"); 
        }
    }

    class  PrivateParentClass
    {
        void print()
        {
            Console.WriteLine(" in private parent class Namespace");
        }
    }
}

namespace NamespaceDemo.Child
{
    class a
    {
        ParentClass pc = new ParentClass();
    }
}

