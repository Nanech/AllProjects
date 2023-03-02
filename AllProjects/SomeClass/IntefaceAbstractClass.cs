using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{

    public class StartTask
    {
        public static void startTheTask()
        {
            Rectangle rect = new Rectangle();
            rect.findTheSquare();
            rect.findThePerimeter();

            //Triangle triangle = new Triangle(); 
            //triangle.findTheSquare();
            //triangle.findThePerimeter();
            
        }
    }



    abstract class GeomentryFigure
    {
        
        abstract public double findTheSquare();

        abstract public double findThePerimeter();

        public double findTheOtres(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt( Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2));
        }

    }

    class Rectangle : GeomentryFigure
    {
        protected double a;
        protected double b;

        public Rectangle()
        {
            Console.WriteLine("Введите первую сторону");
            this.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второую сторону");
            this.b = Convert.ToDouble(Console.ReadLine()); ;
        }

        public override double findThePerimeter()
        {
            return  2*(a+b);
        }

        public override double findTheSquare()
        {
            return a*b;
        }
 
    }

    class Triangle : GeomentryFigure
    {

        protected double a, b, c, d, e, f;

        public Triangle(double a, double b, double c)
        {
            Console.WriteLine("Введите первую сторону");
            this.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второую сторону");
            this.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третью сторону");
            this.c = Convert.ToDouble(Console.ReadLine());
        }

        public Triangle(double a, double b, double c, double d, double e, double f)
        {
            Console.WriteLine("Введите x кординату первой стороны "); // 1 - х
            this.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y кординату первой стороны ");// 1 - у
            this.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x кординату второй стороны "); //2 -х
            this.c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите у кординату второй стороны ");//2-у
            this.d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x кординату третьей стороны ");//3-х
            this.e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите у кординату третьей стороны ");//3-у
            this.f = Convert.ToDouble(Console.ReadLine());

            double first = findTheOtres(a, e, b, f);
            double second = findTheOtres(a, c, b, d);
            double third = findTheOtres(c,e , d ,f );
            this.a = first;
            this.b = second;
            this.c = third;
        }

        public override double findThePerimeter()
        {
            return a+b+c;
        }

        public override double findTheSquare()
        {
            double p = a + b + c / 2;
            return Math.Sqrt(p*(p-1)*(p-b)*(p-c));
        }

            


        interface InterfRecrtangle
        {

        }


        interface InterfRTriangle
        {

        }
    }


}
