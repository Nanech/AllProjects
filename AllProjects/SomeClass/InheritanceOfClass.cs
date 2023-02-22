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
            bp.ShowArra();
            Console.WriteLine();
            //bp.SortByBubbles();
            int a = bp.MaxEl;
            Console.WriteLine("{0} - максимальный элемент массива", a);
            

            Daughter dg = new Daughter();
            Console.WriteLine("Дочерний класс сортировка методом пузырька");
            dg.SortByBubbles();
            Console.WriteLine(dg.Max());

            Console.WriteLine();
            Console.WriteLine("Произведение замены");
            dg.Zamena();
            dg.ShowArra();

        }
    }


    class BasicParent
    {
        public int[] arra = new int[50];
        protected int maxEl;

        public int MaxEl { get => Max();}

        public BasicParent()
        {
            Random r = new Random();
            for(int i = 0; i < arra.Length; i++)
            {
                arra[i] = r.Next(-100,100);
            }
            this.arra = arra;
        }

        public void ShowArra()
        {
            for (int i = 0; i < arra.Length; i++)
            {
                Console.Write("{0} ", arra[i]);
            }
            Console.WriteLine();
        }

        public virtual void SortByBubbles()
        {
            for (int i = 0; i < arra.Length - 1; i++)
            {
                for (int j = 0; j < arra.Length-1-i; j++)
                {
                    if (arra[j] > arra[j+1])
                    {
                        int tmp = arra[j];
                        arra[j] = arra[j + 1];
                        arra[j + 1] = tmp;
                    }
                }
            }
            ShowArra();
        }


        public int Max()
        {
            int max = arra[0];
            for (int i = 1; i < arra.Length; i++)
            {
                if (arra[i] > max ) { max = arra[i]; }
            }
            return max;
        }

    }

    class Daughter : BasicParent
    {

        public override void SortByBubbles()
        {
            Console.WriteLine("Переопределённый метод");
            Array.Sort(arra);
            foreach (int i in arra) { Console.Write(i + " "); }
        }


        new public string Max()
        {
            maxEl = arra.Max();
            int index = Array.IndexOf(arra, MaxEl);
            return MaxEl+" - макс элемент, затем его индекс "+index ; 
        }

        public int[] Zamena()
        {
            int maxEl = arra.Max();
            int minEl = arra.Min();
            int indElMin = Array.IndexOf(arra, minEl);
            int indElMx = Array.IndexOf(arra, maxEl);
            Console.WriteLine("{0} максимальный элемент массива и его индекс {1} и минимальный {2} и его индекс {3}", maxEl, indElMx, minEl, indElMin);
            int tmp = arra[indElMin];
            arra[indElMin] = arra[indElMx];
            arra[indElMx] = tmp;
            return arra;
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

    class Child2 : Parent2
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



}
