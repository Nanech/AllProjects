using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{

    public class IntefaceAbstractClass
    {
        public static void startTheTask()
        {
            //Rectangle rect = new Rectangle();
            //rect.findTheSquare();
            //rect.findThePerimeter();

            //Triangle triangle = new Triangle(); 
            //triangle.findTheSquare();
            //triangle.findThePerimeter();



            Console.WriteLine("Как вы хотите вводить переменные 1 как стороны, 2 как точки ");
            int n = Convert.ToInt32(Console.ReadLine());


            switch (n)
            {
                case 1:                    
                        Console.WriteLine("Введите первую сторону");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите второую сторону");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите третью сторону");
                        double c = Convert.ToDouble(Console.ReadLine());
                        InterfTriangle varOfTriangleInterface = new StartTriangleIntefaces(a, b, c);
                        Console.WriteLine("Периметр {0} площадь {1}", varOfTriangleInterface.findThePerimeter(), varOfTriangleInterface.findTheSquare());
                    break;
                case 2:
                    Console.WriteLine("Введите x кординату первой стороны "); // 1 - х
                    double d = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите y кординату первой стороны ");// 1 - у
                    double e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите x кординату второй стороны "); //2 -х
                    double f = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите у кординату второй стороны ");//2-у
                    double g = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите x кординату третьей стороны ");//3-х
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите у кординату третьей стороны ");//3-у
                    double i = Convert.ToDouble(Console.ReadLine());
                    InterfTriangle varOfTriangleInterface1 = new StartTriangleIntefaces(d, e, f, g, h,  i);
                    Console.WriteLine("Периметр {0} площадь {1}", varOfTriangleInterface1.findThePerimeter(), varOfTriangleInterface1.findTheSquare());

                    break;

                default: Console.WriteLine("Что то пошло не так");  break;
            }


        }
    }



    abstract class GeomentryFigure // Абстрактный класс фигуры
    {
        
        // Абстрактные методы Площади и Периметра

        abstract public double findTheSquare();

        abstract public double findThePerimeter();

        public double findTheOtres(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt( Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2));
        }

    }

    class Rectangle : GeomentryFigure //Первый класс наследник
    {
        protected double a;
        protected double b;

        public Rectangle() // Конструктор
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

    class Triangle : GeomentryFigure //Второй класс наследник
    {

        protected double a, b, c, d, e, f;

        public Triangle(double a, double b, double c) // Конструктор
        {
            Console.WriteLine("Введите первую сторону");
            this.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второую сторону");
            this.b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третью сторону");
            this.c = Convert.ToDouble(Console.ReadLine());
        }

        public Triangle(double a, double b, double c, double d, double e, double f) // Через координаты перегрузка
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


    }


    //Два интерфейса Прямогугольник И Треугольник

    interface InterfRecrtangle
    { //Периметр и площадь 
        double findThePerimeter();
        double findTheSquare();
    }


    interface InterfTriangle
    { //Периметр и площадь
        double findThePerimeter();
        double findTheSquare();
    }


    public class StartRectangleIntefaces : InterfRecrtangle
    {
        protected double a;
        protected double b;

        public StartRectangleIntefaces()
        {
            Console.WriteLine("Введите первую сторону");
            this.a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второую сторону");
            this.b = Convert.ToDouble(Console.ReadLine()); ;
        }

        public  double findThePerimeter()
        {
            return 2 * (a + b);
        }

        public  double findTheSquare()
        {
            return a * b;
        }

        // Информация о определение информации
    }


    public class StartTriangleIntefaces : InterfTriangle
    {
        protected double a, b, c, d, e, f;

        public StartTriangleIntefaces(double _a, double _b, double _c)
        {

            this.a = _a;
            this.b = _b;
            this.c = _c;

            this.b = Convert.ToDouble(Console.ReadLine());
            this.c = Convert.ToDouble(Console.ReadLine());
        }

        public double findTheOtres(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public StartTriangleIntefaces(double _a, double _b, double _c, double _d, double _e, double _f)
        {
            this.a = _a;
            this.b = _b;
            this.c = _c;
            this.d = _d;
            this.e = _e;
            this.f = _f;
            double first = findTheOtres(a, e, b, f);
            double second = findTheOtres(a, c, b, d);
            double third = findTheOtres(c, e, d, f);
            this.a = first;
            this.b = second;
            this.c = third;
        }

        public  double findThePerimeter()
        {
            return a + b + c;
        }

        public  double findTheSquare()
        {
            double p = a + b + c / 2;
            return Math.Sqrt(p * (p - 1) * (p - b) * (p - c));
        }


        // Информация о определение информации
    }



}
