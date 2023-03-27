using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AllProjects.SomeClass
{
    struct PersonBinary
    {
        public string Name;
        public string Surname;
        public string Patronymic;
        public int Age;
        public string Gender;

        public PersonBinary(string name, string surname, string patronymic, int age, string gender)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Age = age;
            Gender = gender;
        }

        public override string ToString()
        {
            return Name + " " + Surname + " " +  Patronymic + " " + Age + " " + Gender;
        }
    }


    internal class BinaryFiles
    {


        public static void PrintAndReadBinary()
        {

            string Path = @"PackageWithFiles/BinaryFile";
            string PathPath = @"PackageWithFiles/BinaryFileWithArray";
            
            using (BinaryWriter bw = new BinaryWriter(File.Open(Path, FileMode.OpenOrCreate)))
            {           
                PersonBinary p1 = new PersonBinary("Валерий", "Сёмонович", "Леонидович", 30, "мужской");
                bw.Write(p1.Name);
                bw.Write(p1.Surname);
                bw.Write(p1.Patronymic);
                bw.Write(p1.Age);
                bw.Write(p1.Gender);
            }

            using (BinaryReader br = new BinaryReader(File.Open(Path, FileMode.Open)))
            {
                string name = br.ReadString();
                string surname = br.ReadString();
                string patronymic = br.ReadString();
                int age = br.ReadInt32();
                string gender = br.ReadString();

                PersonBinary p1 = new PersonBinary(name, surname, patronymic, age, gender);
                Console.WriteLine(p1);
            }


            using (BinaryWriter bw = new BinaryWriter(File.Open(PathPath, FileMode.OpenOrCreate)))
            {
                PersonBinary[] user = new PersonBinary[5];

                user[0] = new PersonBinary("Алексей", "Васильевич", "Леонидович", 61, "мужчина");
                user[1] = new PersonBinary("Николай", "Миколович", "Маркович", 34, "мужчина");
                user[2] = new PersonBinary("Василий", "Леонтьевич", "Никитин", 18, "мужчина");
                user[3] = new PersonBinary("Анфиса", "Киса", "Павловна", 24, "женщина");
                user[4] = new PersonBinary("Елизавета", "Морозова", "Дмитриевна", 14, "женщина");

                foreach (PersonBinary u in user)
                {
                    bw.Write(u.Name);
                    bw.Write(u.Surname);
                    bw.Write(u.Patronymic);
                    bw.Write(u.Age);
                    bw.Write(u.Gender);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Массив");
            using (BinaryReader br = new BinaryReader(File.Open(PathPath, FileMode.Open)))
            {
                PersonBinary[] user = new PersonBinary[5];
                int i = 0;
                while (br.PeekChar() > -1)
                {
                    string name = br.ReadString();
                    string surname = br.ReadString();
                    string patronymic = br.ReadString();
                    int age = br.ReadInt32();
                    string gender = br.ReadString();

                    user[i] = new PersonBinary(name, surname, patronymic, age, gender);
                    Console.WriteLine(user[i]);
                    i++;
                }
            }
        }

    }
}
