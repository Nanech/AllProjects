using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{
    internal class StaticMethods
    {
        // В общем минимальное значение это мин разряд, а максимальный наибольший разряд
        // Вариант 1

        static protected void FirstTask(ref double  m, ref double n)
        {
            double doubleNumber = m / n;
            Console.WriteLine("Дробное число {0}", doubleNumber);
            double integerPartOfNumber = Math.Truncate(doubleNumber);
            doubleNumber = doubleNumber - integerPartOfNumber;
            char[] UpperNumb = doubleNumber.ToString().ToCharArray();
            char[] MinNumb = integerPartOfNumber.ToString().ToCharArray();
            m = double.Parse(UpperNumb[Array.IndexOf(UpperNumb, ',') + 1].ToString());
            n = double.Parse(MinNumb[MinNumb.Length-1].ToString());
        }

        static protected void SecondTask(ref double a, ref double b, ref double c)
        {
            a =  a > 0 ?  Math.Pow(a, 3) : Math.Pow(a, 4);
            b =  b > 0 ?  Math.Pow(b, 3) : Math.Pow(b, 4);
            c =  c > 0 ?  Math.Pow(c, 3) : Math.Pow(c, 4);
        }


        static protected double ThirdTask(double sum, double n)
        {
            if (1 == n) { return sum + 1; }
            return ThirdTask(sum += Math.Pow(n, 3), n -= 1); ; 
        }




        static public void StartStaticMethod()
        {
            // Task 1

            Console.WriteLine("Введите число m");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число n");
            double n = Convert.ToDouble(Console.ReadLine());
            FirstTask(ref m, ref n);
            Console.WriteLine("Старшая цифра дробной части - {0}, младшая цифра целой части - {1}", m, n);

            // Task 2

            //Console.WriteLine("Введите число a");
            //double a = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите число b");
            //double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите число a");
            //double c = Convert.ToDouble(Console.ReadLine());
            //SecondTask(ref a, ref b, ref c);
            //Console.WriteLine("{0} {1} {2}", a, b, c );

            // Task 3

            //Console.WriteLine("Введите n");
            //double n = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("сумма последовательности идущих n кубов {0}", ThirdTask(0, n));




        }



    }
}
