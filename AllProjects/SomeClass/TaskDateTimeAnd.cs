using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{
    internal class TaskDateTimeAnd
    {
        public static void StartDateTime()
        {
            //Экземпляр с датой и времени сейчас
            DateTime dt1 = new DateTime();
            dt1 = DateTime.Now;

            Console.WriteLine(dt1);
            
            //Разные форматы
            Console.WriteLine("Like year {0}", dt1.Year);
            Console.WriteLine("Like mouth {0}", dt1.Month);
            Console.WriteLine("Like day {0}", dt1.Day);
            Console.WriteLine("Like day of week {0}", dt1.DayOfWeek);
            Console.WriteLine("Like day of year {0}", dt1.DayOfYear);
            Console.WriteLine("Like day {0}", dt1.Hour);
            Console.WriteLine("Like minute {0}", dt1.Minute);
            Console.WriteLine("Like second {0}", dt1.Second);
            Console.WriteLine("Like timespan time of day {0}", dt1.TimeOfDay);
             
            // Экземпляры TineSpan и сумма с разностью 
            DateTime dt2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime dt3 = new DateTime(2023, 03, 30);
            TimeSpan minus =  dt2-dt3;
            TimeSpan plus = new TimeSpan(1,0,0,0);
            DateTime plusEquals = dt2.Add(plus);

            Console.WriteLine("The plus {0}", minus );
            Console.WriteLine("The plus {0}", plusEquals);

            // Мой день рождение
            DateTime bd = new DateTime(2003, 10, 22);
            TimeSpan birthday = dt1.Subtract(bd);
            Console.WriteLine("My age in years {0} ",  Math.Floor( (double) (birthday.Days / 365)));
            Console.WriteLine("My age in mouths {0} ", Math.Floor((double)(birthday.Days / 365))*12 );
            Console.WriteLine("My age in days {0} ",  birthday.Days);
        }
    }
}
