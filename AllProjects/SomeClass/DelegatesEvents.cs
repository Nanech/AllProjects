using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{

    delegate int Delegate1(int i);
    delegate void Delegate2();

    public class SomeDelegates
    {
        static public int method1(int n)
        {
            return n;
        }
        static public int method2(int n)
        {
            return n * n;
        }
        static public void method3()
        {
            Console.WriteLine("Method 3 started");
        }
        static public void method4()
        {
            Console.WriteLine("Method 4 started");
        }

    }


    internal class DelegatesEvents
    {
        

        static public void StatrTheDelegate()
        {
            Delegate1 d1 = new Delegate1(SomeDelegates.method2);
            Delegate1 d2 = SomeDelegates.method1;
            Delegate2 d3 = SomeDelegates.method3;
            d3 -= SomeDelegates.method4;


            //int h = d2(14);
            d3();

            Console.WriteLine();
 
        }

    }
}
