using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{
    internal class TriangleForTesting
    {
        double a, b, c;

        public TriangleForTesting()
        {
            try
            {
                Console.WriteLine("Введите первую сторону треугольника");
                a = Convert.ToDouble(Console.ReadLine());
                this.a = a;
                Console.WriteLine("Введите вторую сторону треугольника");
                b = Convert.ToDouble(Console.ReadLine());
                this.b = b;
                Console.WriteLine("Введите третью сторону треугольника");
                c = Convert.ToDouble(Console.ReadLine());
                this.c = c;
            }
            catch (Exception e)
            {
                Console.WriteLine("Возникла ошибка {0}", e.Message);
            }
           
        }


        public void StartMethodTriangle()
        {
            if (a + b != c && b + c != c && a + c != b) 
            {
                if (a == b && a == c) { Console.WriteLine("Треугольник равносторонний"); }
                else if (a == b || b == c || c == b) { Console.WriteLine("Треуольник является равнобедренным"); }
                else { Console.WriteLine("Треугольник разностороний"); }
            }
            else { Console.WriteLine("Треугольника не существует"); }
        }


    }
}
