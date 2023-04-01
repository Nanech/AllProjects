using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{
    internal class ControlFirst
    {
        struct Mans 
        {
            public string name;
            public int pullUpls;
            public double time;

            public Mans(string name, int pullUpls, double time)
            {
                this.name = name;
                this.pullUpls = pullUpls;
                this.time = time;
            }

            public override string ToString()
            {
                return name + " " +  pullUpls + " " + time;
            }
        }


        public static void startSolution()
        {
            string Path = @"результаты соревнований.txt";
            FileInfo fileInfo = new FileInfo(Path);
            string[] readText = File.ReadAllLines(Path);
            List<Mans> mans = new List<Mans>();
            for (int i = 0; i < readText.Length; i +=2)
            {
                string name = readText[i].TrimEnd(':');
                string[] results = readText[i + 1].Split(' ');

                int pullUps1 = Convert.ToInt32(results[0]);
                int pullUps2 = Convert.ToInt32(results[2]);
                int pullUps3 = Convert.ToInt32(results[4]);

                string[] time1 = results[1].Split(':');
                TimeSpan timeSpan1 = new TimeSpan( 0, 0, Convert.ToInt32(time1[0]), Convert.ToInt32(time1[1]), 0);

                string[] time2 = results[3].Split(':');
                TimeSpan timeSpan2 = new TimeSpan(0, 0, Convert.ToInt32(time2[0]), Convert.ToInt32(time2[1]), 0);

                string[] time3 = results[5].Split(':');
                TimeSpan timeSpan3 = new TimeSpan(0, 0, Convert.ToInt32(time3[0]), Convert.ToInt32(time3[1]), 0);

                TimeSpan time = timeSpan1 + timeSpan2 + timeSpan3;
                
                double timeDouble = time.TotalSeconds;
                int pullUps  = pullUps1 + pullUps2 + pullUps3;

                Mans person = new Mans(name, pullUps, timeDouble);
                mans.Add(person);                
            }
  
            List<Mans> Champions = mans.OrderByDescending(x => x.pullUpls).ToList();

            string PathNew = @"result.txt";

            foreach (Mans person in Champions)
            {
                Console.WriteLine(person);
            }

            using (StreamWriter w = new StreamWriter(PathNew))
            {
                w.WriteLine("Чемпионы\n");
                int i = 0;
                int pull = 0;
                foreach (Mans person in Champions)
                {
                    if (pull == person.pullUpls)
                    {
                        w.WriteLine("{0} {1}", i, person);
                        Console.WriteLine("{0} {1}", i, person);
                    }
                    else 
                    {
                        i++;
                        w.WriteLine("{0} {1}", i, person);
                    }
                  
                    pull = person.pullUpls;

                }
            }


        }



    }
}
