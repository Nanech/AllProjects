using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AllProjects.SomeClass
{
    internal class RegularExpressions
    {


        public static void StartRegular()
        {
            Regex mailIndex = new Regex(@"^[0-9]{6}$");

            Regex Passport = new Regex(@"^[0-9]{2}\s[0-9]{2}\s[0-9]{6}$");

            Regex telephone = new Regex(@"^(\+7|8)[0-9]{10}$");

            Regex group = new Regex(@"^[1-4]{2}(П|Л|Б|Ю|В){1}$");

            Regex password = new Regex(@"^(?=.*[0-9]{1,})(?=.*[a-z]{3,})(?=.*[A-Z]{1,})(?=.*[*+=\-!@#$%^&()_'::\\]{1,})[0-9a-zA-Z*+=\-!@#$%^&()_'::/\\]{8,}$"); 
            //The messeage why is not match

            
            //Console.WriteLine(mailIndex.IsMatch("123456"));
            //Console.WriteLine(mailIndex.IsMatch("12d4561"));

            //Console.WriteLine(Passport.IsMatch("22 22 123456"));
            //Console.WriteLine(Passport.IsMatch("22 22 12z456"));

            //Console.WriteLine(telephone.IsMatch("+79081552086"));

            //Console.WriteLine(group.IsMatch("34П"));

            //Console.WriteLine(password.IsMatch("1asdO*+:"));
        }

    }
}
