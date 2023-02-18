using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{
    internal class InheritanceOfClass
    {
        public void start_InhertianceOfClass()
        {
            //Пример из лекции

            //Наследование
            //Parent p1 = new Parent();
            //p1.show();
            //Child1 c1 = new Child1();
            //c1.show();

            //Переопределение и замещение методов в производных классах

            //Parent2 p2 = new Parent2();
            //p2.display();
            //Console.WriteLine();
            //Child2 c2 = new Child2();
            //c2.display();
            //c2.show();

            //Конструкторы классов при наследовании

            //Parent3 p3 = new Parent3();
            //Parent3 p3 = new Parent3(24);
            //p3.show();
            //Child3 c3 = new Child3(234);
            ////Child3 c3 = new Child3(15);
            //c3.show();


            //Наследование свойств индикаторов
            //Parent p4 = new Parent();
            //Child1 c4 = new Child1();
            //int a = p4.ShowInteger;
            //p4.ShowInteger = a;


            //Задание 2
     
            BasicParent bp = new BasicParent();
            int[] a = bp.CreateArra;
            bp.ShowArra();

    }
    }

    class Parent
    {
        protected int i = 10;
        //int i = 10;
        string s = "привет";


        public void show()
        {
            Console.WriteLine("строковое поле равно {0}, а числовое {1}, а объект, который его вызывает {2}", s, i, GetType().Name);
        }


        public int ShowInt 
        {
            get { return i; }
            set { i = value; }
        }
        
        public virtual int ShowInteger
        { 
            get { return i; }
            set { i = value; }
        }

    }

    class Child1 : Parent
    {

        new public int ShowInt
        {
            get { return i; }
            set { i = value; }
        }

        public override int ShowInteger
        {
            get { return i; }
            set { i = value; }
        }
    }

    class Parent2
    {
        protected void show()
        {
            Console.WriteLine("Я обычный метод родительского класса");
        }

        protected virtual void vshow()
        {
            Console.WriteLine("я виртуальный метод родительского класса");
        }

        public void display()
        {
            show();
            vshow();
        }
    }

    class Child2: Parent2
    {
        new public void show()
        {
            Console.WriteLine("Я замещенный метод в производном классе");
        }
        //Для переопределения нужно, чтобы в родителе был метод виртуал (который мы хотим наследоать)
        //А в дочернем слово override
        protected override void vshow()
        {
            Console.WriteLine("я переопределеный виртуальный метод");
        }
    }


    class Parent3
    {
        public int n;

        //public Parent3()
        //{
        //    n = 10;
        //}

        public Parent3(int n)
        {
            this.n = n;
        }

        public void show()
        {
            Console.WriteLine("Ваше число {0}", n);
        }

    }

    class Child3 : Parent3
    {


        //public Child3()
        //{
        //    n = 20;
        //}

        //public Child3(int n) 
        //{
        //    this.n = n;
        //}

        //public Child3() : base(234) // В данном случае конструктору родительского класса передаётся 234
        //{
        //    n = 20;
        //}

        //public Child3(int n) :base(234)
        //{
        //    this.n = n;
        //}

        public Child3(int n) : base(n) { }


    }

    



    class BasicParent
    {
        public int[] arra = new int[50];

        //Лучше делать через конструктор

        public int[] CreateArra
        {
            get 
            {
                Random r = new Random();
                foreach (int i in arra) { arra[i] = r.Next(0, 100); }
                return arra;
            }
            set { arra = value; }
        }

        public void ShowArra()
        {
            foreach (int n in arra)
            {
                Console.Write("{0} ", arra[n]);
            }
            Console.WriteLine();
        }

    }






}
