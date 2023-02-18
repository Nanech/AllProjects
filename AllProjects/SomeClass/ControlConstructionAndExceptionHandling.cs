using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{
    internal class ControlConstructionAndExceptionHandling
    {
        static public void StartControl()
        {
            //Console.WriteLine(Function_1.fucnction_1());

            Console.WriteLine(Function_2.getNumber());

            //Function_3.print_sequence();

            //Console.WriteLine(Function_4.function_4());

            //Function_5.function_5();


        }

    }

    public class Function_1
    {
        public const double E = 2.7182818284590451;
        static public double fucnction_1()
        {
            try
            {
                Console.WriteLine("Введите сначала x затем y");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double a = 3 + Math.Pow(E, y - 1);
                double b = Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x));
                double c = a / b;
                if (double.IsInfinity(c)) { throw new Exception("На ноль не делим"); }
                return c;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Программа выдала сбой, так как на ноль делить нельзя. Программа вернёт 0");
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Случилась другая непредвиденная ошибка {e.Message}, программа вернёт 0");
                return 0;
            }
        }
    }

    public class Function_2
    {
        static public bool getNumber()
        {
            try
            {
                Console.WriteLine("Напишите число трехзначное число");
                string str = Console.ReadLine();
                if (str.Length != 3) { throw new Exception("Введенно не трехзначное число"); }
                int Number = Convert.ToInt32(str);
                int a = Number % 10;
                Number /= 10;
                int b = Number % 10;
                Number /= 10;
                int c = Number % 10;
                Number = a + b + c;
                Console.WriteLine("Сумма чисел {0} равна {1}", str, Number);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Возникла ошибка - {0} ", e.Message);
                return false;
            }
        }

    }

    public class Function_3
    {
        public static void print_sequence()
        {
            try
            {
                Console.WriteLine("Введите натуральное число N, до которого дойдёт последовательность");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ваша последовательность: ");
                for (int i = 1; i <= N; i++)
                {
                    if (i % 2 == 0) { Console.Write("{0} ", i); }
                    else if (N == i && i == 1) { throw new Exception("Была введена единица, последовательности не будет выведена"); }
                    else if (N < 0) { throw new Exception("Введено не натуральное число, а точнее меньше 0"); }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Вызвано исключение: {0}", e.Message);
            }
        }
    }

    public class Function_4
    {
        static public double function_4()
        {
            try
            {
                Console.WriteLine("Введите натуральнео число N");
                int N = Convert.ToInt32(Console.ReadLine());
                if (N < 0) { throw new Exception("Введено отрицательное число"); }
                else if (N == 0) { throw new Exception("Введён ноль"); }
                double sum = 1; double somedouble;
                for (double i = 2; i <= N; i++)
                {
                    somedouble = 1 / i;
                    sum += somedouble;
                }
                Console.Write("Ответ: ");
                return sum;
            }
            catch (Exception e)
            {
                Console.WriteLine("Вызвано исключение: {0}, ответ будет ноль", e.Message);
                return 0;
            }
        }
    }

    public class Function_5
    {
        static public void function_5()
        {
            try
            {
                Console.WriteLine("Сколько стоит книга");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Сколько книг");
                int count = Convert.ToInt32(Console.ReadLine());
                if (count <= 0) { throw new Exception("Книг не может быть меньше 0"); }
                else if (price <= 0) { throw new Exception("Книг не может стоит меньше 0, или быть бесплатной"); }
                Console.WriteLine("Введите ваши средства");
                double account = Convert.ToDouble(Console.ReadLine());
                if (account < 0) { throw new Exception("Ваш баланс не может быть отрицательным"); }

                if (account == price) { Console.WriteLine("Спасибо, за соверншённую покупку!"); }
                else if (account > price) { Console.WriteLine("Возьмите вашу сдачу {0} . Спасибо за покупку", account - price); }
                else if (account < price) { Console.WriteLine("Вам не хватает {0} ", price - account); }

            }
            catch (Exception e)
            {
                Console.WriteLine("Вызвано исключение: {0}", e.Message);
            }
        }
    }

}
