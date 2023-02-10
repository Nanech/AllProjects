using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AllProjects.SomeClass; // Теперь могу обращаться к папке 

namespace AllProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeRedefinition1 type1 = new TypeRedefinition1(10, "Hello, World!");
            TypeRedefinition1 type2 = new TypeRedefinition1(20, "Bye bye, World!");
            //Console.WriteLine( type2 / type1);
           
            //явный случай
            //int a = (int)type1;
            //Console.Write( a );
            //Console.WriteLine();
                
            //неявный случай           
            //string b = type1;
            //Console.WriteLine( b );


            ArrayCreate array1 = new ArrayCreate(10);
            array1.showArray();
            Console.WriteLine();
            array1[9] = 1;
            Console.WriteLine(array1[9]);
            


            Console.ReadKey();
        }
    }
}
