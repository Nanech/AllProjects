using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AllProjects.SomeClass
{
    /// <summary>
    /// До дополнительного
    /// </summary>
    internal class TypeRedefinition1
    {
        //Poles
        int a;
        string str;
        public int A { get => a; set => a = value; }
        public string Str { get => str; set => str = value; }

        //Свойства
        public TypeRedefinition1(int a, string str)
        {
            this.A = a;
            this.Str = str;
        }

        
        //Переопределение Метода
        public override string ToString()
        {
            return "строковое поле: " + Str +  ", а число равно "+ A;
        }
        public override bool Equals(object obj)
        {
            return (int)obj == A;
        }

        //Переопределение операндов
        public static TypeRedefinition1 operator +(TypeRedefinition1 c1, TypeRedefinition1 c2)
        {
            TypeRedefinition1 c3 = new TypeRedefinition1(c1.A + c2.A, c1.Str + c2.Str);
            return c3;
        }    
        public static TypeRedefinition1 operator -(TypeRedefinition1 c1, TypeRedefinition1 c2)
        {
            TypeRedefinition1 c3 = new TypeRedefinition1(c1.A - c2.A, c1.Str + c2.Str);
            return c3;
        }    
        public static TypeRedefinition1 operator *(TypeRedefinition1 c1, TypeRedefinition1 c2)
        {
            TypeRedefinition1 c3 = new TypeRedefinition1(c1.A * c2.A, c1.Str + c2.Str);
            return c3;
        }    
       public static TypeRedefinition1 operator /(TypeRedefinition1 c1, TypeRedefinition1 c2)
        {
            TypeRedefinition1 c3 = new TypeRedefinition1(c1.A / c2.A, c1.Str + c2.Str);
            return c3;
        }    
        public static bool operator >(TypeRedefinition1 c1, TypeRedefinition1 c2)
        {
            return c1.A > c2.A;
        }
        public static bool operator <(TypeRedefinition1 c1, TypeRedefinition1 c2)
        {
            return c1.A > c2.A;
        }
        public static bool operator >=(TypeRedefinition1 c1, TypeRedefinition1 c2)
        {
            return c1.A >= c2.A;
        }
        public static bool operator <=(TypeRedefinition1 c1, TypeRedefinition1 c2)
        {
            return c1.A <= c2.A;
        }
        public static bool operator ==(TypeRedefinition1 c1, TypeRedefinition1 c2)
        {
            return c1.A == c2.A;
        }
        public static bool operator !=(TypeRedefinition1 c1, TypeRedefinition1 c2)
        {
            return c1.A != c2.A;
        }

        //Переопределение типов
        public static explicit operator int (TypeRedefinition1 c1) //явное
        {
            return c1.A;
        }
        public static implicit operator string (TypeRedefinition1 c1 )//неявное
        {
            return c1.A.ToString() ;
        }
       

    }

    /// <summary>
    /// Дополнительное
    /// </summary>
    class ArrayCreate
    {
        object array;
        int SizeOfMassiv;
        Random rand = new Random();

        public ArrayCreate(int n)
        {
            SizeOfMassiv = 1;
            int[] arra = new int[n];
            for (int i = 0; i < n; i++)
            {
                arra[i] = rand.Next(100);
            }
            array = arra;
        }

        public ArrayCreate(int n, int m)
        {
            SizeOfMassiv = 2;
            int[,] arra = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arra[i,j] = rand.Next(100);
                }
            }
            array = arra;
        }

        public void showArray()
        {
            switch (SizeOfMassiv)
            {
                case 1:
                    int[] arra = (int[])array;
                    for (int i = 0; i < arra.Length; i++)
                    {
                        Console.Write( $"{arra[i]} ");
                    }
                    break;
                case 2:
                    int[,] arra1 = (int[,])array;
                    for (int i = 0; i < arra1.GetLength(0); i++)
                    {
                        for (int j = 0; j < arra1.GetLength(1); i++)
                        {
                            Console.Write($"{arra1[i, j]} ");
                        }
                        Console.WriteLine();  
                    }
                    break;

                default:
                    Console.WriteLine("Как так");
                    break;
            }
        }

        public int this[int k]
        {
            get 
            {
                int[] arra = (int[])array;
                return arra[k];
            }
            set
            {
                int[] arra = (int[])array;
                arra[k] = value;
            }
        }

        public int this[int k, int m]
        {
            get 
            {
                int[,] arra = (int[,])array;
                return arra[k,m];
            }
            set
            {
                int[,] arra = (int[,])array;
                arra[k,m] = value;
            }
        }



        public void startTypeRedefin()
        {
            TypeRedefinition1 type1 = new TypeRedefinition1(10, "Hello, World!");
            TypeRedefinition1 type2 = new TypeRedefinition1(20, "Bye bye, World!");
            //Console.WriteLine( type2 / type1);

            //явный случай
            //int a = (int)type1;
            //Console.Write( a );
            //Console.WriteLine();

            //неявный случай           
            //string b = type1;
            //Console.WriteLine( b );


            ArrayCreate array1 = new ArrayCreate(10);
            array1.showArray();
            Console.WriteLine();
            array1[9] = 1;
            Console.WriteLine(array1[9]);
        }
    }

}
