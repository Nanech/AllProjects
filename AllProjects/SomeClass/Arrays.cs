using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AllProjects.SomeClass
{
    internal class Arrays
    {      
        public static void StartArray()
        {
            // Variant 1

            //First task
            //InitArray t1 = new InitArray(5);
            //t1.FirstTask();

            //Second task
            //InitArray t2 = new InitArray(10);
            //t2.SecondTask();

            // Third task
            //InitArray t3 = new InitArray(5, 6, "letters");
            //t3.ThirdTask();

            //Fourth task
            //InitArray t4 = new InitArray(4, 4);
            //t4.FourthTask(1, 9);


            // Fifth task
            InitArray t5 = new InitArray(5, 5);
            t5.FifthTask(1, 100);

        }
    }


    internal class InitArray
    {
        protected int n;
        protected int[] firstArray;

        public int m;
        public int[,] secondArray;
        public char[,] stringArray;

        public InitArray(int n, int m)
        {
            this.n = n;
            this.m = m;
            this.secondArray = new int[n, m];
        }       
        
        public InitArray(int n, int m, string c)
        {
            this.n = n;
            this.m = m;
            this.stringArray = new char[n, m];
        }

        public InitArray(int n)
        {
            this.n = n;
            this.firstArray = new int[n];
        }

        public void  FirstTask()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)  { firstArray[i] = rnd.Next(-100, 100); }

            int min = firstArray.Min();
            int indMin = Array.IndexOf(firstArray, min);

            int max = firstArray.Max();
            int indMax = Array.IndexOf(firstArray, max);

            foreach (int i in firstArray) { Console.Write("{0} ", i); }

            Console.WriteLine();
            int temp = max;
            firstArray[indMax] = min;
            firstArray[indMin] = temp;
            
            foreach (int i in firstArray) { Console.Write("{0} ", i); }
        }


        public void SecondTask()
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++) { firstArray[i] = rand.Next(1, 10); }

            foreach (int i in firstArray) 
            { Console.WriteLine("Число {0}, его остаток от деления на 10 равен {1}", i, (double)i/10 ); }
        }

        public void ThirdTask()
        {
            Random rand = new Random();
            for ( int i = 0; i < n;i++) 
            {
                for (int j = 0; j < m; j++)
                {
                    stringArray[i, j] = (char)rand.Next(97, 123); //a to z
                    Console.Write("{0} ", stringArray[i,j]);
                }  
                Console.WriteLine();
            }

        }

        public void FourthTask(int downValue, int highValue )
        {

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    secondArray[i, j] = rnd.Next(downValue, highValue + 1); 
                    Console.Write("{0} ", secondArray[i, j]);
                }
                Console.WriteLine() ;
            }
            int[] a = new int[m];
            for (int i = 0; i < n; i++)
            {
                a[i] = Enumerable.Range(0, m).Select(x => secondArray[i, x]).ToArray().Sum();  
                Console.WriteLine("Сумма строки {0} = {1}", i, a[i]);
            }
        }


        public void FifthTask(int downValue, int highValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    secondArray[i, j] = rnd.Next(downValue, highValue + 1);
                    Console.Write("{0} ", secondArray[i,j]);
                }
                Console.WriteLine() ;
            }

            int[] a = new int[m];
            int maxElement = 0 ;
            int iteratorI = 0, iteratorJ = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = Enumerable.Range(0, m).Select(x => secondArray[i, x]).ToArray().Max();
                if (a[i] > maxElement) 
                {
                    maxElement = a[i]; iteratorI = i;
                    iteratorJ = Array.IndexOf( Enumerable.Range(0, n).Select(x => secondArray[iteratorI, x]).ToArray(), maxElement);
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0} and {1}", iteratorI, iteratorJ);
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == iteratorI){ secondArray[i, j] = 0; }
                    else if (j == iteratorJ) { secondArray[i, j] = 0; }
                    Console.Write("{0} ", secondArray[i, j]);
                }
                Console.WriteLine() ;
            }

            int[,] matrix = new int[n - 1, m - 1];
            int count = 0; bool flag = false;
            for (int i = 0; i < n; i++)
            {
                int counter = 0;
                for (int j = 0; j < m; j++)
                {
                    if (secondArray[i,j] != 0) { matrix[count, counter] = secondArray[i, j]; counter++; }
                }
                if (Enumerable.Range(0, m).Select(x => secondArray[i, x]).ToArray().Max() != 0) { count++; }
            }

            Console.WriteLine();
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < m-1; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }

}
