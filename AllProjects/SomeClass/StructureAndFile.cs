using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AllProjects.SomeClass
{

    struct User 
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Gender;

        public User(string name, string surname, int age, string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " + Age +  " " + Gender;
        }
    }


    internal class StructureAndFile
    {

        static public void CreateArrayAndWriteInFile()
        {
            User[] user = new User[5];

            user[0] = new User("Алексей", "Васильевич", 61, "мужчина");
            user[1] = new User("Николай", "Миколович", 34, "мужчина");
            user[2] = new User("Василий", "Леонтьевич", 18, "мужчина");
            user[3] = new User("Анфиса", "Киса", 24, "женщина");
            user[4] = new User("Елизавета", "Морозова", 14, "женщина");

            string Path = @"PackageWithFiles/StructureAndFile.txt";

            using (StreamWriter w = new StreamWriter(Path))
            {
                foreach (User pers in user)
                {
                    w.WriteLine(pers);
                }
            }

        }

    }
}
