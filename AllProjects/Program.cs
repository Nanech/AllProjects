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
            InheritanceOfClass inh = new InheritanceOfClass();
            inh.start_InhertianceOfClass();


            Console.ReadKey();
        }
    }
}
