using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;

using AllProjects.SomeClass; // Теперь могу обращаться к папке 

namespace AllProjects
{
    //class SomeMethods
    //{

    //    public int[] InitArray()
    //    {
    //        Console.WriteLine("Введите размерность массива");
    //        int n = Convert.ToInt32(Console.ReadLine());
    //        int[] arra = new int[n];
    //        Random r = new Random();
    //        for (int i = 0; i < arra.Length; i++)
    //        {
    //            arra[i] = r.Next(0, 11);
    //        }
    //        return arra;
    //    }


    //    public void ShowArray(int[] a )
    //    {
    //        for (int i = 0; i < a.Length; i++)
    //        {
                
    //            Console.WriteLine("{0} ", a[i]);
    //        }
    //        Console.WriteLine();
    //    }


    //}




    internal class Program
    {
        static void Main(string[] args)
        {
            //Debug.Listeners.Add(new TextWriterTraceListener("newLog.log"));
            //Debug.AutoFlush = true;
            //Debug.Indent();

            //SomeMethods m1 = new SomeMethods();
            //Debug.WriteLine("Object of class SomeMethod created like m1");
            //int[] a = m1.InitArray();
            //Debug.WriteLine("Array was created like with name 'a' ");
            //Console.WriteLine();    

            //m1.ShowArray(a);

            //Debug.Unindent();
            //var myWriter = new TextWriterTraceListener();
            //Debug.Listeners.Add(myWriter);

            //ControlConstructionAndExceptionHandling.StartControl();

            //InheritanceOfClass inf = new InheritanceOfClass();
            //inf.start_InhertianceOfClass();


            //TriangleForTesting trin = new TriangleForTesting();
            //trin.StartMethodTriangle();





            Console.ReadKey();
        }
    }
}
