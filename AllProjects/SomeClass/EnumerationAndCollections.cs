using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{
    internal class EnumerationAndCollections
    {

        enum TheDayOfWeek
        {
            Monday,  
            Tuesday,  
            Wednesday,
            Thursday, 
            Friday,  
            Saturday, 
            Sunday 
        }



        public static void StartThatClas()
        {

            string[] weeks = Enum.GetNames(typeof( TheDayOfWeek));
            Console.WriteLine("Введите день недели");
            int n = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("{0}",  weeks[n]);



        }

    }
}
