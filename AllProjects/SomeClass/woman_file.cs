using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AllProjects.SomeClass
{
    struct Person 
    {
        public string name;
        public int podtyagivanie;
        public int nails;

        public Person(string name, int podtyagivanie, int nails)
        {
            this.name = name;
            this.podtyagivanie = podtyagivanie;
            this.nails = nails;
        }

        public override string ToString()
        {
            return name + " " + podtyagivanie + " " + nails;
        }
    }


    internal class woman_file
    {
        public static void strartSolution()
        {
            string Path = @"X:\Мухин\Sharp_project\AllProjects\AllProjects\SomeClass\результаты соревнований.txt";
            FileInfo fileInfo = new FileInfo(Path);
            string[] readText = File.ReadAllLines(Path);
            List<Person> people = new List<Person>();
            for (int i = 0; i < readText.Length; i +=2)
            {
                string[] pullupAndnails = readText[i + 1].Split(' ');//Разбиваем вторую строку
                string name = readText[i].TrimEnd(':');
                int countPullups = Convert.ToInt32(pullupAndnails[0]) + Convert.ToInt32(pullupAndnails[2]) + Convert.ToInt32(pullupAndnails[4]);
                int countNails = Convert.ToInt32(pullupAndnails[1]) + Convert.ToInt32(pullupAndnails[3]) + Convert.ToInt32(pullupAndnails[5]);
                Person newpers = new Person(name, countPullups, countNails);
                people.Add(newpers);
            }
            
            List<Person> Champion = people.OrderByDescending(x=>x.podtyagivanie).Where(nail => nail.nails < 10).ToList();
            List<Person> Disqualified = people.OrderBy(x => x.name).Where(nail => nail.nails > 10).ToList();

            Console.WriteLine();
            Console.WriteLine("Сейчас будут чемпионки");
            Console.WriteLine();
            foreach (Person person in Champion)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine();
            Console.WriteLine("Сейчас будут предательницы");
            Console.WriteLine();

            string champs = String.Join("\r\n", Champion);
            string disqvalid = String.Join("\r\n", Disqualified);

            foreach (Person person in Disqualified)
            {
                Console.WriteLine(person);
            }

            string PathNewNew = @"X:\Мухин\Sharp_project\AllProjects\AllProjects\SomeClass\чемпионки и дисквалифицирован.txt";
            
            using (StreamWriter w =  new StreamWriter(PathNewNew))
            {
                w.WriteLine("Чемпионки\n");
                int i = 1;
                foreach (Person person in Champion)
                {
                    w.WriteLine( $"{i} " + person);
                    i++;
                }
                w.WriteLine("\nДисквалифицированные\n");
                foreach(Person person in Disqualified)
                {
                    w.WriteLine(person);
                }
            }

        }
    }
}
