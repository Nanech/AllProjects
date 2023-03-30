using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{
    delegate int Delegate1(int i);
    delegate void Delegate2();
    delegate int Delegate3(int[] i);

    class ClassNumb1
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
            Console.WriteLine("Запустился метод 3");
        }   
        
        static public void method4()
        {
            Console.WriteLine("Запустился метод 4");
        }        

        static public void method5()
        {
            Console.WriteLine("Запустился метод 5");
        }


    }


    class ClassNumb2
    {
        Delegate1 d1;

        static int method1(int n)
        {
            return n;
        }

        static int method2(int n)
        {
            return n * n;
        }

        //расскоментируй посмотри в чем разница

        //public int method3(int n)
        //{
        //    if (n % 2 == 0)
        //    { d1 = method1; }
        //    else { d1 = method2; }
        //    int k = d1(n);
        //    return k;
        //}

        //public Delegate1 method3(int n)
        //{
        //    switch (n)
        //    {
        //        case 1:
        //            d1 = method1;
        //            break;
        //        case 2:
        //            d1 = method2;
        //            break;
        //        default:
        //            break;
        //    }
        //   
        //    return d1;
        //}
        
        public Delegate1 this[int n]
        {
            get
            {
                switch (n)
                {
                    case 1:
                        d1 = method1;
                        break;
                    case 2:
                        d1 = method2;
                        break;
                    default:
                        break;
                }
                return d1;
            }

        }

    }


    class ClassNumb3
    { 
        // Работа с анонимными методами - метод у которого нет имени
        // В классе нужно инициализировать что то после создания объекта
        // Если у различных объектов одного и того же класса требуется разные версии методов
                
        public Delegate1 d1;
    }



    delegate void task1(char c);
    // Когда void мы можем создавать экземпляр
    class FirstTask
    {
        static public char pole;
        static public void method(char c)
        {
            pole = c;
        }
    }

    delegate int task2(char c, string str);
    class SecondTask
    {
        task2 t2;

        static int method1(char c, string str)
        {
            return str.ToCharArray().Count( x => x  == c);
        }

        static int method2(char c, string str)
        {
            if (str.ToCharArray().Count(x => x == c) >0)
            {
                return Array.IndexOf(str.ToCharArray(), c) +1;
            }
            return -1;
        }

        public task2 this[int n]
        {
            get
            {
                switch (n)
                {
                    case 1:
                        t2 = method1;
                        break;
                    case 2:
                        t2 = method2;
                        break;
                    default:
                        break;
                }
                return t2;
            }
        }
    }

    delegate double task3(double a, double b, double c);
    delegate double task4(double a, double b, double c);
    class ThirdTask { public task3 t3; }

    internal class DelegatesEvents
    {
        // Делегат это контейнер, который хранит в себе более одного метода
        // Иногда нужно наслаивать какие то методы друг на друга (чтобы шли два одних и тех же)
        // Если свойство одно то используй один метод, а если нет то другой
        // В основном это синтаксический сахар
        // Работать с анонимными методами и лямбда-выражениями
        // Когда нужно отработать событие
        // Создав делегат единожды можно в него вкладывать потом все что угодно

        public static void MineDelegates()
        {
            // Task 1

            //task1 t1 =  new task1 ( FirstTask.method);
            //Console.WriteLine(FirstTask.pole);
            //t1('h');
            //Console.WriteLine(FirstTask.pole);

            // Task 2

            //SecondTask second = new SecondTask();
            //Console.WriteLine(second[1]('h', "hchccc") );
            //Console.WriteLine();
            //Console.WriteLine(second[2]('h', "cchccc") );

            // Task 3
            
            //ThirdTask third = new ThirdTask();
            //third.t3 = delegate (double a, double b, double c)
            //{
            //    double D = b * b - 4 * a * c;
            //    if (D < 0) { return 0; }
            //    double x1 = (-b + Math.Sqrt(D)) / 2 * a;  
            //    double x2 = (-b - Math.Sqrt(D)) / 2 * a;  
            //    return x1+ x2;
            //};
            //Console.WriteLine(third.t3(1, 6, 3));


            // Task 4

            //task4 t4;
            //t4 = (x,y,z) =>
            //{
            //    double D = y * y - 4 * x * z;
            //    if (D < 0) { return 0; }
            //    double x1 = (-y + Math.Sqrt(D)) / 2 * x;
            //    double x2 = (-y - Math.Sqrt(D)) / 2 * x;
            //    return x1 + x2;
            //};
            //Console.WriteLine(t4(1, 6, 3));

        }

        public static void SecondVersionDelegateClassWork()
        {
            //ClassNumb2 c1 = new ClassNumb2();
            //Console.WriteLine(c1.method3(10));

            //ClassNumb2 c1 = new ClassNumb2();
            //Delegate1 d1 = c1.method3(2);
            //Console.WriteLine(d1(12));

            //ClassNumb2 c1 = new ClassNumb2();
            //Console.WriteLine(c1[1](12)); //вау
            // Можно индексировать методы внутри класса, с приватными полями

            ClassNumb3 c1 = new ClassNumb3();
            c1.d1 = delegate (int i)
            {
                return i;
            };
            Console.WriteLine(c1.d1(123));

            ClassNumb3 c2 = new ClassNumb3();
            c2.d1 = delegate (int i)
            {
                return i * i;
            };
            Console.WriteLine(c2.d1(12));       
            
            ClassNumb3 c3 = new ClassNumb3();
            c3.d1 = i => i * i;  //через ляммбда-выражение
            // Так пишем только потому что у нас один аргумент, и ясен какой (один) тип переменной
            Console.WriteLine(c3.d1(9));

            Delegate3 d1;
            int[] a = new int[2];
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                a[i]  = random.Next(100);
                Console.Write(a[i] + " ");
            }

            d1 = w => {
                int s = 0;
                for (int i = 0; i < 2; i++)
                {
                    s += w[i];
                }
                return s;
            };

            Console.WriteLine(d1(a));

        }

        public static void StartDelegateClassWork()
        {
            // экземпляр делегата
            Delegate1 d1 = new Delegate1(ClassNumb1.method2);
            Console.WriteLine(d1(10));

            // Можно и так делегат объявить
            Delegate1 d2 = ClassNumb1.method1;
            Console.WriteLine(d2(14));
            int h = d2(24);

            // Ещё и вот так написать можно
            Delegate2 d3 = ClassNumb1.method3;
            d3 += ClassNumb1.method4;
            d3 += ClassNumb1.method5;
            d3(); Console.WriteLine();
            d3 -= ClassNumb1.method5;
            d3();
        }
    }
}
